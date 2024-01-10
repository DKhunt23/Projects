"""
This is FAQ Bot Plus Phase 2
This file is used to load the data from fuzzy_logic.txt and answer.txt (ref: https://en.wikipedia.org/wiki/Booster_Juice)
Functions: 
            find_best_match     - return match length
            generate            - return response based on index (answer file)
            classify_speech     - whether user utterance is question/command/statement
            extract_noun_chunks - return the best noun chunk 
            fallback_response   - generate response based on question/command/statement
            generate_search_link- generate google link with specific word in user utterance

            main function initiate and print the final output

Matching works based on the length of longest matched string 
question.txt file with alternate questions


Dipsa Khunt,2023
"""

import regex as re
import spacy
from spacy.matcher import Matcher
import file_input

# spacy.cli.download("en_core_web_lg")
nlp = spacy.load("en_core_web_lg")
matcher = Matcher(nlp.vocab)
matcher_question = Matcher(nlp.vocab)
matcher_command = Matcher(nlp.vocab)

"""loads data from files"""
def load_FAQ_data():

    questions = file_input.file_input('fuzzy_logic.txt')

    answers = file_input.file_input('answers.txt')
    
    return questions, answers

"""loading data"""    
fuzzylogic, responses =load_FAQ_data()

# patterns for question and command 
question_pattern =  [{"lower":{"in": ["?", "how", "what", "where", "why", "when", 
                     "which", "who", "whom", "whose"]}, "OP": "?"}]
command_pattern = [
   {"lower": {"in": ["give", "tell", "send", "make", "drive", "go"]}}
   
]

# adding patterns to matcher
matcher_question.add("QuestionPattern", [question_pattern])
matcher_command.add("CommandPattern", [command_pattern])
matcher.add("NounChunks",[[{"POS": {"in": ["NOUN", "PROPN"]}}]])
   
def classify_speech(userspeech):
    """
        This function classify the user utterance in question/command/other by matching with pattern 
        params : user_speech - user utternace
        return : question/command/statement - user utterance is which of this
    """ 
    doc = nlp(userspeech)
    
    question_matches = matcher_question(doc)
    command_matches = matcher_command(doc)
    #classify speech in question/command/statement
    if question_matches:
        return "question"
    elif command_matches:
        return "command"
    else:
        return "statement"

def extract_noun_chunks(user_speech):
    """
        This function finds best noun chunk from the all the noun chunk in user utterance 
        params : user_speech - user utternace
        return : noun chunk with best score
    """ 
    doc = nlp(user_speech)
    noun_chunks = [chunk.text for chunk in doc.noun_chunks]
  
    # no noun chunk found 
    if not noun_chunks:
        return doc
    else:
        best_score = {}
        for noun_chunk in noun_chunks:
            noun = nlp(noun_chunk)
            best_chunk = doc.similarity(noun)
        best_score[noun_chunk] = best_chunk
    # return best noun chunk based on score
    return max(best_score, key=best_score.get)


def fallback_response(speech_act, noun_chunks,search_link):
    """
        This function generates response when it cannot find in answer file 
        params : speech_act - classified value of(is it a question/command/other)
               : noun_chunks - noun found in user utterance
        return : response based on speech_act
    """

    # responses based on speech and with link
    if speech_act == "question":
        return f"Sorry, I don't have information about {''.join(noun_chunks)}. You could try searching {search_link} "
    elif speech_act == "command":
        return f"Sorry, I don't know how to do that. My responses are restricted to inquiries about Booster Juice."
    elif speech_act == "statement":
        return f"Sorry, I don't know, but you could try searching {search_link} "
    else:
        return f"Sorry, I'm not sure what you mean. You could try searching {search_link} "


def generate_search_link(user_speech):
    """
        This function geenrate search link whenever it doesnt find response from answer file and it doesnt match as question or command
        params : user_speech - user utternace
        return : link to google created based on user utterance
    """
    user_speech = re.sub(r"[^a-zA-Z0-9]+", "%20", user_speech)
    # genereating link
    link =  f"https://www.google.com/search?q={user_speech}"
    return link



def find_best_match(pattern, user_utterance):
    """
        This function find the best matching regex on the basis of max length of match pattern
        params : pattern - fuzzylogic
               : user_utterance - question asked by user
        return : len of match
    """
    match = re.search(pattern, user_utterance, flags=re.IGNORECASE|re.BESTMATCH)
  
    # cannot find match in question file
    if match == None:
        return 0
    else:
        # found match return length of match
        return len(match.group())

def generate(best_match,user_question):
    """
        This function generate response for user based on the index passed as parameter
        params: best_match - index number
              : user_question - user utterance
        return: response for user from answer file if found else bot will reply according to user utterance
    """
    
    global responses 
    if(best_match == -1):
        # classifying speech
        speech_act = classify_speech(user_question)
        # generating link
        search_link = generate_search_link(user_question)

        if speech_act in ["question", "command"]:
            noun_chunks = extract_noun_chunks(user_question)
            # calling fucntion for generating response
            response = fallback_response(speech_act,noun_chunks,search_link)
            return response
        elif speech_act in ["statement"]:
            response = fallback_response(speech_act,noun_chunks,search_link)
        else: 
            return f"Sorry, I don't know, but you could try searching: {search_link}"
    else:
        # found match in question file then generate response based on that index
        return responses[best_match]


def main():
    """Implemented in shell"""
    print("Hello! I know stuff about Booster Juice. When you're done talking, just say 'goodbye/quit'.")
    print()
    
    utterance = ""
    while True:
        utterance = input(">>> ")

        best_match = -1  #used for indexing purpose
        min_match_count = -1 #count 
        user_question = utterance.lower()  # Set the user's input 
        for i in range(len(fuzzylogic)):
            match_length = find_best_match(fuzzylogic[i], user_question) #calling fucntion which will return length of matching string
            
            #if length of matching string is more then change the best_match will that index
            if(match_length!=0):
                if(match_length < 2):
                    best_match = -1
                else:
                    best_match = i
                    min_match_count = match_length
      
        print(generate(best_match,user_question)) # printing response
    

if __name__ == "__main__":
    main()




