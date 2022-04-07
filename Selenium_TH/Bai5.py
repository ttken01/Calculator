

import csv


with open('user.csv','w', newline='') as f:
        fileName = ['user','password']
        writer= csv.DictWriter(f, fieldnames= fileName)
        writer.writeheader()
        writer.writerow({'user':'1951052144','password':'01644273828'})



with open('user.csv', 'r', newline='') as f:
    reader= csv.DictReader(f)
    for row in reader:
        user = row['user']
        password= row['password']
        print(user)
        print(password)