import csv

from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.support.ui import Select
from selenium.common.exceptions import NoSuchElementException


driver = webdriver.Chrome(executable_path='D:\chromedriver.exe')
driver.maximize_window()

driver.get('https://vnexpress.net/')


driver.find_element(By.CSS_SELECTOR,"a.btn24hqua").click()

driver.find_element(By.CSS_SELECTOR,"li.khoahoc").click()


articles = driver.find_elements(By.CSS_SELECTOR, 'article.item-news')
for a in articles:
  try:
     title = a.find_element(By.CSS_SELECTOR, 'h3.title-news').text
     description = a.find_element(By.CSS_SELECTOR, 'p.description > a').text
     link = a.find_element(By.CSS_SELECTOR, 'h3.title-news>a').get_attribute('href')

     print("Title: "+title)
     print("Description: " + description)
     print("Link: "+ link)
     with open('NguyenLongNhat.csv', 'a', encoding="utf-8", newline='') as f:
         fileName = ['Title', 'Description', 'Link']
         writer = csv.DictWriter(f, fieldnames=fileName)
         writer.writeheader()
         writer.writerow({'Title': title, 'Description': description, 'Link': link})

  except NoSuchElementException:
   pass


driver.close()