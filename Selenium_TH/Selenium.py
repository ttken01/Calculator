#N=5
class Cau1:
    def __init__(self):
        n
    def InHinhVuong(self,n):
        for x in range(n):
            print("*"*n)

    def InTamGiacVuongTrai(self,n):
        for i in range(n):
            print("*"*i)

    def InTamGiacVuongPhai(self,n):
        for i in range(n+1):
            print(" "*(n-i)+"*"*i)

    def InTamGiacCan(self,n):
        for i in range(1, n+1):
            if i%2!=0 :
                numberWhite = n-i
                numberStar = i
                print(round(numberWhite/2)*" " + "*"*numberStar)

#n = int(input("Nhap n: "))
#
#test = Cau1()
#test.InHinhVuong(n)
#test.InTamGiacVuongTrai(n)
#test.InTamGiacVuongPhai(n)
# test.InTamGiacCan(n)


class Cau2:
    def FindMinMax(self):
        a = []
        n = int(input("Nhap so luong phan tu: "))
        for i in range(n):
            a.append(int(input()))
        minA = min(a)
        maxA = max(a)
        maxStr = maxA.__str__()
        minStr = minA.__str__()
        if maxA < 0:
            maxStr = "*"
        if minA > 0:
            maxStr = "*"
        print("So duong lon nhat la: " + maxStr + "\n"
              + "So am be nhat la: " + minStr)

# test2 = Cau2()
# test2.FindMinMax()



class Cau3:
    dict = {
        'information' : 'Thong tin',
        'go': 'di',
        'do': 'lam'
    }
    def Add(self, a = True):
        key = str(input("Nhap key: "))
        value = str(input("Nhap value: "))
        if (key not in self.dict.keys()):
            self.dict[key] = value

        else:
            print("da co tu!!!!")
    def AllItems(self, a = True):
        print("Tu dien:")
        print(self.dict)


    def Search(self, a = True):
        kw = str(input("Nhap tu muon tim: "))
        for k in self.dict.keys():
            if k == kw:
                print("key: ", str(kw), "\n co gia tri: ", str(self.dict[kw]))
                return True
        print("Khong co tu do!")

    def Delete(self, a = True):
        kw = str(input("Nhap tu muon xoa: "))
        for k in self.dict.keys():
            if k == kw:
                del self.dict[kw]
                return True
        print("khong co tu do!!!")
#
# test = Cau3()
# test.Delete(True)
# test.AllItems(True)

class Cau4:
    employees = [{
        "ma_nv": 1,
        "ten_nv": "Nguyễn Văn A",
    }, {
        "ma_nv": 2,
        "ten_nv": "Dương Trọng C",
    }, {
        "ma_nv": 3,
        "ten_nv": "Nguyễn Thanh N",
    }]
    def HienThi(self, a = True):
        for k in self.employees:
            print("Ma nhan vien: ", k["ma_nv"])
            print("Ten nhan vien ", k["ten_nv"])

    def TimKiem(self, a = True):
        kw = str(input("Tim theo ten: "))
        for k in self.employees:
            if k["ten_nv"].__contains__(kw):
                print("Ma nhan vien: ", k["ma_nv"])
                print("Ten nhan vien ", k["ten_nv"])

    def Xoa(self, a = True):
        kw = int(input("Nhap id can xoa: "))
        for k in self.employees:
            if int(k["ma_nv"]) == kw:
                del self.employees[k]
                return True


test = Cau4()
test.HienThi(True)
test.Xoa(True)
test.HienThi(True)
