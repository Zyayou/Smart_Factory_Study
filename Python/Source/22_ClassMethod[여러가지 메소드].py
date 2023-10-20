################################################################################################
# # 클래스 변수
# # 클래스 자체로 데이터를 관리하는 변수
# # . 인스턴스화 하지 않아도 곧바로 외부에서 접근하여 관리 할 수 있는 변수
################################################################################################


# class car :     
#     def __init__(self, year) :
#         self.year = year
#         car.totalcount += 1

#     totalcount = 0 # 클래스 변수 # 클래스에서는 밑에와도 작동함

# print(car.totalcount)

# pride = car(2023)
# print(pride.totalcount)
# print(car.totalcount)

# sm = car(2022)
# print(sm.totalcount)
# print(car.totalcount)

# sm.totalcount = 100
# print(pride.totalcount)
# print(sm.totalcount)
# print(car.totalcount)

# car.totalcount = 50
# print(pride.totalcount)
# print(sm.totalcount)
# print(car.totalcount)





################################################################################################
# # 클래스 메서드
# # 클래스 변수를 관리 할 수 있도록 클래스 자체를 인자로 전달 받을 수 있는 클래스
# # - 클래스 변수를 관리 할 수 있도록 Data 영역에 메서드를 등록해 두는 메서드
# #   . 클래스 변수 자체를 외부에 공개 하지 않을 수 있다. (데이터 보호, 접근성, 캡슐화)
################################################################################################


# class car :     

#     totalcount = 0 

#     def __init__(self, year) :
#         self.year = year
#         car.totalcount += 1

#     @classmethod
#     def setcount(cls, countvolum) :
#         cls.totalcount += countvolum # cls = 카 클래스
#         print(cls.totalcount)


# # 클래스 메서드 호출
# car.setcount(10)
# car.setcount(5)





############## 정적 메소드
# # 프로그램 전반적으로 사용하는 변수나 값, 메서드가 있는 경우 인스턴스화 하지 않고
# # 편리하게 사용할 수 있도록 data영역에 등록해두는 method
# # classmethod와 같은 원리이지만, 클래스 변수를 관리하지 않는다.


# class car :     

#     totalcount = 0 

#     def __init__(self, year) :
#         self.year = year
#         car.totalcount += 1

#     @staticmethod
#     def setcount() :
#         return "차량의 판매 수량"
    
# print(car.setcount())


################ 연산자 메서드
# # 자주 사용하는 연산 기능을 메서드로 만들어 간편하게 사용할 수 있도록 만득 특수 메서드
# # . 클래스에 연산자 메서드를 정의 시 비교 연산을 할 수 있다.

# class Human :
#     def __init__(self, age, name) :
#         self.name = name
#         self.age = age

# kim = Human(33, '김범수')
# bum = Human(33, '김범수')
# na = Human(40, '나얼')
# park = Human(40, '박효신')

# print(kim == bum) # Fulse (서로 다른 객체 메모리 주소 참조라서)




# # 만약에 kim 과 bum의 나이와 이름이 같은지 비교하는 연산자로 == 을 사용하고 싶을 때
# class Human :
#     def __init__(self, age, name) :
#         self.name = name
#         self.age = age
#     def __eq__(self, other) :
#         return self.age == other.age and self.name == other.name

# kim = Human(33, '김범수')
# bum = Human(33, '김범수')
# na = Human(40, '나얼')
# park = Human(40, '박효신')

# print(kim == bum) # __eq__를 통해 나이와 이름의 값이 같은지 비교수 bool 값을 반환



# # 두 객체간의 - 연산시 처리되는 결과를 반환하도록 하는 메서드 __sub__
# class Human :
#     def __init__(self, age, name) :
#         self.name = name
#         self.age = age
#     def __eq__(self, other) :
#         return self.age == other.age and self.name == other.name
#     def __sub__(self, other) :
#         return abs(self.age - other.age)

# kim = Human(33, '김범수')
# bum = Human(33, '김범수')
# na = Human(40, '나얼')
# park = Human(40, '박효신')

# print(na - bum) 



# # 같은 객체간의 __r.sub__
# class Human :
#     def __init__(self, age, name) :
#         self.name = name
#         self.age = age
#     def __eq__(self, other) :
#         return self.age == other.age and self.name == other.name
#     def __rsub__(self, other) :
#         return abs(self.age - other)

# kim = Human(33, '김범수')
# bum = Human(33, '김범수')
# na = Human(40, '나얼')
# park = Human(40, '박효신')

# print(20 - na)  # 정수객체(변수)의 human 객체 na를 rsub로 비교할 경우 결과가 반환
# print(kim - na) # 같은 객체를 비교할 경우는 __rsub__만 있을경우 오류를 반환
#                 # __sub__ 메서드가 있어야한다. (왼쪽 형을 기준으로 비교하는 연산자가 우선순위이기 때문)






#############################################################
# # 특수메서드 __str__
# # . 객체를 약속된 로직으로 문자열화 하여 반환한다.

# # 리스트 객체를 출력할 경우 데이터를 확인할 수 있다.
# lists = [1,2,3]
# print(lists)

# # zip클래스를 출력할 경우 데이터를 확인하는게 아닌 메모리 주소를 반환
# lists = [1,2,3]
# lists2 = [1,2,3,4]
# lists3 = zip(lists, lists2)
# print(lists3)

# # 두 클래스 (리스트, zip) 간에 __str__이 구현되어있는 로직잉 다르기 때문




# # 리스트와 같은 결과를 출력하는 MyList 클래스 만들어 보기
# class MyList :
#     def __init__(self, *message) :
#         self.message = message
#     def __str__(self) :
#         # 클래스 객체를 출력할 경우 호출되는 특수 메서드
#         result = '['
#         for value in self.message :
#             result += str(value) + ', '
#         result = result[:-2]
#         result += ']'
#         return result

# lists = MyList(10,20,30,40,50)
# print(lists)



# # 리스트의 개수를 반환하는 __len__ 특수 메서드
class MyList :
    def __init__(self, *message) :
        self.message = message
    def __str__(self) :
        # 클래스 객체를 출력할 경우 호출되는 특수 메서드
        result = '['
        for value in self.message :
            result += str(value) + ', '
        result = result[:-2]
        result += ']'
        return result
    def __len__(self) :
        count = 0
        for value in self.message :
            count += 1
        return count


lists = MyList(10,20,30,40,50)
print(lists)
print(len(lists))