from selenium import  webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By

# str= input("Write your keywords")

driver = webdriver.Chrome(executable_path='venv/chromedriver.exe')
driver.get('https://google.com/')


element = driver.find_element(By.CSS_SELECTOR, ".gLFyf")
# element = driver.find_element(By.NAME, "q")
element.send_keys("react")
element.submit()

results = driver.find_elements(By.CSS_SELECTOR,'div.g')
u=0
for r in results:
    if(u==0):
        pass
    else:
        title = r.find_element(By.TAG_NAME, 'h3').text
        link = r.find_element(By.TAG_NAME, 'a').get_attribute('href')
        print(u)
        print('Title: '+ title)
        print('Link: '+ link)
    u = u + 1




