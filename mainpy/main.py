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
		for message in client.iter_messages(1170485847):
			print(message.sender_id, ':', message.text)


if __name__ == '__main__':
	send()	