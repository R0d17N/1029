#!/usr/bin/env python
# coding: utf-8

from telethon.sync import TelegramClient
from telethon import errors
import time
import random
import config

api_id = config.api_id
api_hash = config.api_hash

def send():
   with TelegramClient('Session', api_id, api_hash) as client:
      try:
         with open("id.txt", "r", encoding='utf-8') as file:
            u_id = int(file.readline())
            with open("text.txt", "r", encoding='utf-8') as file2:
               text = str(file2.readline())
               client.send_message(u_id, text)

      except errors.FloodWaitError as e:
         print('Flood wait for ', e.seconds)
         time.sleep(random.randrange(230, 330))

if __name__ == '__main__':
   f = open('text.txt', "r", encoding='utf-8')
   line = f.readlines()
   print(line)
   send()