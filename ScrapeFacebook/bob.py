#!/usr/bin/python
# -*- coding: <UTF-8> -*-
import requests 
from bs4 import BeautifulSoup
from selenium import webdriver
import time
from secrets import username,password
from webdriver_manager.chrome import ChromeDriverManager
import io
import os
from selenium.webdriver.common.by import By

#go to facebook
url = 'https://www.facebook.com'
pageContent = ''

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
#809360946357600 indicates the group to navigate to
driver.get('https://mbasic.facebook.com/groups/809360946357600')
see_more = True

while(see_more):
    try:
        pageContent = pageContent + driver.page_source
        soup = BeautifulSoup(pageContent, 'html.parser')
        element = driver.find_element_by_link_text("See more posts")
        element.click()
    except :
        see_more = False


#save the html of the page you want to scrape

#print(pageContent)
#use beautifulsoup to extract the content


#print the HTML conent of the page you wish to scrape
#print(pageContent)

#close the webdriver
driver.close()



def extractData():
    #delete content file if it already exists to avoid duplicate data
    if(os.path.exists("Articles.txt")):
        os.remove("Articles.txt")
    else:
        print("The file you want to delete, does not exsit!")
    #all posts with no imges
    #find a post
    for post in soup.find_all('article'):
        #print(post)
        #check if there was a checkin on the post which = location
        if (post.find_all('h3', {'class': 'bs dj dk dl'})):
            for name_and_place in post.find_all('h3', {'class': 'bs dj dk dl'}):
                if(name_and_place.find_all('a')):
                    #if there was a location extract the location
                    for a_tag in name_and_place.find_all('a'):
                        
                        if(a_tag.text == "Wild Life Facts"):
                            namePlace = "No location was found"
                        else:
                            namePlace = a_tag.text
        else:
            #if there was no location insert default value
            namePlace = "No location was found"
        """elif (post.find_all('h3', {'class': 'bs ba dj dk'})):
            for name_and_place in post.find_all('h3', {'class': 'bs ba dj dk'}):
                if(name_and_place.find_all('a')):
                    for a_tags in name_and_place.find_all('a'):
                        namePlace = "No location was found" """
        #find all sub text of posts
        for paragraph in post.find_all('p'):
            #print(paragraph.text)
            paragraphs = paragraph.text
            if(paragraph.text == ""):
                #if there is no subtext insert a default value
                paragraphs = "No sub text was posted"
            else:
                paragraphs = paragraph.text
            #find all images in posts
            for date in post.find_all('abbr'):
                #print( '\n ')
                dates = date.text
                if post.find_all('a', {'class': 'dr ds dt'}):
                    for img in post.find_all('a', {'class': 'dr ds dt'}):
                        if img.img:
                            #if an image was found extract its URL
                            #print(paragraph.text, ', ', date.text,', ',img.img['src'])
                            imgsrc = img.img['src']
                            #print(namePlace, ', ',paragraphs , ', ', dates,', ',imgsrc)
                            with io.open('Articles.txt', 'a', encoding="utf-8") as postes:
                                for img in post.find_all('a', {'class': 'dr ds dt'}):
                                    postes.write(namePlace + ', '+ paragraphs + ', ' + dates + ', ' + imgsrc+ '\n')
                        else:
                            #if no imgae was posted insert a default value
                            imgsrc = "No image was posted"
                            with io.open('Articles.txt', 'a', encoding="utf-8") as postes:
                                postes.write(namePlace + ', '+ paragraphs + ', ' + dates + ', ' + imgsrc+ '\n') 
                else:
                    # print(paragraph.text, ', ', date.text,', ')
                    imgsrc = "No image was posted"
                    #print(namePlace, ', ',paragraphs , ', ', dates,', ' + imgsrc + '\n')
                    with io.open('Articles.txt', 'a', encoding="utf-8") as postes:
                         postes.write(namePlace + ', '+ paragraphs + ', ' + dates + ', ' + imgsrc+ '\n')

#calling the extract function
extractData()
##############################################################################################################################
command = 'Exit'
os.system(command)