import requests 
from bs4 import BeautifulSoup
from selenium import webdriver
import time
from secrets import username,password
from webdriver_manager.chrome import ChromeDriverManager
import io

#go to facebook
url = 'https://www.facebook.com'


# use chrome browser to navigate and login to facebook using selenium
#driver = webdriver.Chrome()
driver = webdriver.Chrome(ChromeDriverManager().install())
driver.get(url)
time.sleep(2)
#locate the space where the emaio and password must be entered on the webpage
email = driver.find_element_by_name("email")
pswrd = driver.find_element_by_name("pass")
#enter the email and password to login to facebook account
email.send_keys(username)
time.sleep(1)
pswrd.send_keys(password)
time.sleep(3)
email.submit()
time.sleep(10)
#go to the basic (mbasic) facebook website where HTML is less complex than normal facebook website
driver.get('https://mbasic.facebook.com/groups/809360946357600')

#save the html of the page you want to scrape
pageContent = driver.page_source

#use beautifulsoup to extract the content
soup = BeautifulSoup(pageContent, 'html.parser')

#print the HTML conent of the page you wish to scrape
#print(pageContent)

#close the webdriver
driver.close()

#get the title of the page and print it
title = soup.find('title')
print(title.text)




#write all image links to a file
imageFile = open("imgLinks.txt", 'w')
#gives link to images that have been posted
for article in soup.find_all('a',  {'class': 'dr ds dt'}):
    if article.img:
        print(article.img['src'])
        imageFile.write(article.img['src'])
        imageFile.writelines("\n")
 

#write all post info to a file
#articleFile = open('Articles.txt', 'w',encoding="utf-8)
#find all posts 
posts = soup.find_all(['article']) 
with io.open('Articles.txt', 'w', encoding="utf-8") as postes:
    for post in posts:
        print(post.text + "\n")
        postes.write(post.text + "\n" )
        #articleFile.writelines(post.text)

##############################################################################################################################