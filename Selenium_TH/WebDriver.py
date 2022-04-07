from selenium import webdriver
from selenium.webdriver.common.by import By
from  selenium.webdriver.support.ui import  Select
import csv


driver = webdriver.Chrome(executable_path='D:\chromedriver.exe')
driver.get('https://lms.ou.edu.vn/')


driver.implicitly_wait(5)
driver.find_element(By.CSS_SELECTOR,'#about a.main-btn').click()
driver.implicitly_wait(5)
driver.find_element(By.CSS_SELECTOR, 'button.login100-form-btn').click()
driver.implicitly_wait(5)
userType = Select(driver.find_element(By.NAME, 'form-usertype'))
userType.select_by_index(0)

with open('user.csv', 'r', newline='') as f:
    reader= csv.DictReader(f)
    for row in reader:
        user = row['user']
        password= row['password']
userName = driver.find_element(By.NAME,'form-username')
userName.send_keys(user)
matKhau = driver.find_element(By.NAME,'form-password' )
matKhau.send_keys(password)

driver.find_element(By.CLASS_NAME,'m-loginbox-submit-btn').click()
driver.implicitly_wait(5)


courses = driver.find_elements(By.CLASS_NAME, 'span.media-body')
driver.implicitly_wait(5)
for c in courses:
    print(c.text)


driver.close()