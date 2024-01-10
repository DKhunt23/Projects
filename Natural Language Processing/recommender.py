""" This prroject focus on recommendations system. Reads the file and stores its title 
    if there is no title found it takes first 30 words. And display 10 random article first 
    and on the basis of user choice display other 10 calculating cosine similarity 

    There are functions called:
    load_articles - returns articles array
    init_recommendations - return first recommendations list for user
    article_similarity - return cosine similarity list
    display_recommendations - print the list of recommendation
    display_article - print article highlight
    new_recommendations - return new recommendation for user
    main - implemented in shell 


Dipsa Khunt, 2023"""

from csv import DictReader
from random import randint
import json
import numpy as np
from random import shuffle
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.metrics.pairwise import cosine_similarity

NUM_RECS = 10 # number of recommendations to return to the user

def load_articles(filename, filetype="csv"):
    """Returns a list of articles loaded from a json or csv file with a header.
    Each article is a dictionary. If you use one of the files provided, each
    article will have a "title" and "text" field.

    param: filename -  name of file to load
    param: num - number of articles to load (random sample), or None for all articles
    param: filtype - "csv" or "json" """

    # list for articles
    articles = []

    # condition for different file type
    if filetype=="csv":
        with open(filename, encoding="utf-8") as csvfile:
            reader = DictReader(csvfile)
            for row in reader:
                articles.append(row)
    elif filetype=="json":
        with open(filename, encoding="utf-8") as jsonfile:
            articles = json.loads(jsonfile.read())
    
    for row in articles:
        # if article with no title then store first 30 words as title
        if row["title"] == None:
            row["title"] = row["text"][:30]
    
    print("\n*****",len(articles),"articles loaded *****")
    # returning list of articles
    return articles

def article_similarity(user_lastchoice, whole_article):
    """Calculates cosine similarity between the user chosen article from whole articles list.

    param: user_lastchoice - user chosen article in form of vector
    param: whole_article - list of articles in vector
    return: cosine similarity scores
    """
    # return cosine similarity 
    return cosine_similarity(user_lastchoice.reshape(1, -1), whole_article)[0]


def init_recommendations(n, articles):
    """This generates n random recommendations.
       param: n - number of recommendations
       param: articles - list of articles
       return: recommendations for user  """
    # list for recommendations
    recommendations = []

    # append random article in recommendation list
    for _  in range(n):
        article = randint(0, len(articles)-1)
        while article in recommendations:
            article = randint(0, len(articles)-1)
        recommendations.append(article)
    return recommendations

def display_recommendations(recommendations, articles):
    """Displays recommendations. The recommendations parameter should be a list
       of index numbers representing the recommended articles.
       param: recommendations - list of recommendations
       param: articles - list of articles
    """
    # print reommendation list for user
    print("\nHere are some new recommendations for you:\n")
    for i in range(len(recommendations)):
        art_num = recommendations[i]
        print(str(i+1)+".",articles[art_num]["title"])

def display_article(art_num, articles):
    """Displays article 'art_num' from the articles
       param: art_num - 
       param: articles - list of articles"""
    
    print("\n")
    print("article",art_num)
    print("=========================================")
    # article title
    print(articles[art_num]["title"])
    print()
    # article summary
    print(articles[art_num]["text"])
    print("=========================================")
    print("\n")

def new_recommendations(last_choice, n,vectors):
    """Generates recommendations based on the user choice after calculating similarity

    param: last_choice - index number of the last article read
    param: n - number of recommendations
    param: whole_articles - list of article in vector form"""

    # storing vector form of user last choice
    user_lastchoice = vectors[last_choice]
    # calculating similarity of user last choice with whole article
    similarity_scores = article_similarity(user_lastchoice, vectors)

    #storing index of article 
    similar_articles = similarity_scores.argsort()[-n:][::-1]   
    #check that last choice should not be included in recommendation          
    recommendations = [article for article in similar_articles if article != last_choice][:n-2]

    # finding two least similar articles 
    least_similar_articles = np.where(similarity_scores < 0.5)[0]
    # suffling the list of least similar articles
    np.random.shuffle(least_similar_articles)
    # selecting 2 articles from article
    least_similar_articles = least_similar_articles[:2]

    #combining similar and less similar list
    all_recommendations = recommendations + list(least_similar_articles)
    # new recommendations should not include last  choice
    all_recommendations = [article for article in all_recommendations if article != last_choice]

    return all_recommendations


def main():
    """main method"""
    articles = load_articles('data\wikipedia_sample.json',filetype="json")
  

    vectorizer = TfidfVectorizer(stop_words='english', max_df=0.8)
    #article in form of vector
    vectors = vectorizer.fit_transform([article["text"] for article in articles])

    # funtion call to displays first list for user 
    recs = init_recommendations(NUM_RECS, articles)

    while True:
        # print recommendation
        display_recommendations(recs, articles)
        choice = int(input("\nYour choice? "))-1
        # condition to check user choice should be greater than 0 and within length of first recommendation list
        if choice < 0 or choice >= len(recs):
            print("Invalid Choice. Goodbye!")
            break
        # print the article details of user choice
        display_article(recs[choice], articles)
        input("Press Enter ->")
        # new recommendations based on user's choice
        recs = new_recommendations(recs[choice], NUM_RECS,vectors)

if __name__ == "__main__":
    main()