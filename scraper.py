import requests
from bs4 import BeautifulSoup

req = requests.get("https://www.amazon.in/s?i=beauty&rh=n%3A1374407031&fs=true&page=3&qid=16934")

soup = beautifulSoup(req.content, "html.parser")

print(soup.prettify())