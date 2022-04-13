from selenium import  webdriver
from selenium.common.exceptions import NoSuchElementException
from selenium.webdriver.common.by import By

driver = webdriver.Chrome(executable_path='venv/chromedriver.exe')
driver.get('https://www.conferenceseries.com/past-conference-reports.php/')

items = driver.find_elements(By.CSS_SELECTOR, 'a.list-group-item')

# u=0
for i in items:
    title = i.get_attribute('title')
    created_date = i.find_element(By.CSS_SELECTOR,'.col-md-3>span').text
    place = i.find_element(By.CSS_SELECTOR,'div:nth-child(3)').text
    print(title +" === " + created_date + " === " + place)
    # u = u +1
    # if(u==3):
    #     break

driver.close()
