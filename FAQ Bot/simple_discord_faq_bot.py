""" 
This file includes the code for making bot online and talk with user
using the data form file

Dipsa Khunt, 2023

"""
import discord
from implement import *

## MYClient Class Definition

class MyClient(discord.Client):
    """Class to represent the Client (bot user)"""

    def __init__(self):
        """Constructor to set intent."""
        intents = discord.Intents.default()
        intents.message_content = True
        super().__init__(intents=intents)

    async def on_ready(self):
        """This is called when bot successfully login."""
        print('Logged on as', self.user)

    async def on_message(self, message):
        """This is called when bot gets a message."""

        # condition for not answering ourselves
        if message.author == self.user:
            return

        # will generate the response based on utterance
        utterance = message.content
        best_match = -1  #used for indexing purpose
        min_match_count = -1 #count 
        user_question = utterance # Set the user's input 
        for i in range(len(fuzzylogic)):
            match_length = find_best_match(fuzzylogic[i], user_question) #calling fucntion which will return length of matching string
        
            #if length of matching string is more then change the best_match will that index
            if ((match_length > min_match_count) and  (match_length!=0)):
                best_match = i
                min_match_count = match_length
        

        response = generate(best_match,user_question)
        print(response)
        # send the response
        await message.channel.send(response)

## will take the token and run
client = MyClient()
with open("bot_token.txt") as file:
    token = file.read()
client.run(token)