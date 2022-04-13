from selenium import  webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By

driver = webdriver.Chrome(executable_path='venv/chromedriver.exe')
driver.get('https://vnexpress.net/')


print(driver.title)

articles = driver.find_elements(By.CSS_SELECTOR, 'article.item-news')
for a in articles:
  try:
     title = a.find_element(By.CSS_SELECTOR, 'h3.title-news').text
     description = a.find_element(By.TAG_NAME, 'p').text
     link = a.find_element(By.CSS_SELECTOR, 'h3.title-news>a').get_attribute('href')

     # title2 = a.find_element(By.TAG_NAME, 'h3').text
     print("Title: "+title)
     print("Description: " + description)
     print("Link: "+ link)
     # print("title2: " +title2)
  except NoSuchElementException:
   pass


driver.close()