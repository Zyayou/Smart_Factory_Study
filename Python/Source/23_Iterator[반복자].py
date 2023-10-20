###############################################
# # Iterable 클래스
# # 반복 가능한 클래스
# # 요소가 열거되어 있는 (n개 이상의 요소를 가지고 있는 ) 자료형 구조에서 순차적으로 요소를 추출할 수 있는 기능이 포함된 클래스
# # . next() -> __next__()



# # 데이터를 순차적으로 반환하는 반복가능한 클래스 만들기
# class MyList :
#     def __init__(self, *data) :
#         self.data = data
#         self.index = -1   # 추출하는 요소의 index를 나타내는 인스턴스 변수
#     def __next__(self) :
#         # 요소를 하나씩 추출하여 반환하는 메서드
#         self.index += 1
#         if self.index == len(self.data) :
#             # 요소의 끝까지 모두 반환을 다한 상태라면
#             pass
#         return self.data[self.index]


# lists = MyList(10,20,30,40,50,60)
# while True :
#     result = next() # 추출한 요소를 담을 변수  
#     print(result)



##########################################3
# 수업으로 인해 없음
############################################


##############################################################################
# # 함수 데코레이터
# # . 함수에 장식을 붙이듯이 코드의 앞 뒤로 원하는 코드를 추가하는 방법
# # . 함수를 실행하기 전에 별도의 로직을 수행하거나 검증하는 로직을 구현하는 등
# #   인련의 연속적인 일을 정의해 두고 간단하게 호출하여 사용할 수 있도록 한느 문법


### 함수 데코레이터를 이해하기전에 
##### 함수를 래핑하는 기법부터 학습
# # 래핑 : 주요 코드를 가운데 두고 별도의 코드를 앞 뒤로 붙여서 반복적으로 수행 가능하도록 만드는 기법
# def inner() : 
#     print("결과 출력")

# def outer(func) :
#     print("-" * 20)
#     func()
#     print("-" * 20)

# outer(inner)
# # "결과출력"을 표현하기 전에 print() 기능과 표현후 print() 기능이 덧붙여진
# # inner() 함수를 호출한 결과가 도출
# # 특정한 로직을 수행할 때 반복적으로 수행해야하는 로직이 있을 경우
# # 래핑 기법을 사용하여 일괄적으로 처리할 수 있다.


####### 데코레이터의 등장 이유
# # 주요 코드는 inner이지만
# # 마치 outer 함수를 실행하여 결과를 받는것 처럼 보여 코드의 가독성을 낮출 수 있다.
# # inner 메서드를 호출하는 것 처럼 보이지만 래핑 기법이 적용된 기능을 구현하도록 하는 기법이
# # 래핑 패턴이다.

# def inner():
#     print("결과를 출력합니다.")

# def outer(func) :
#     def wrapper() :
#         print("-" * 20)
#         func()
#         print("-" * 20)
#     return wrapper

# inner = outer(inner) # 함수 inner랑은 다름
# # outer를 실행한 결과를 inner 객체에 담사어 마치 inner함수를 직접 호출 하는 것처럼 보이게 하면 되지않을까
# inner() 
# print(inner.__name__) # wrapper를 실행하고 있는것을 확인 할 수 있다.


# # 하지만 비효율 적으로 보임
# # 호출부분을 간단히 처리하게 해주는 문법 (데코레이터)
# def outer(func) :
#     def wrapper() :
#         print("-" * 20)
#         func()
#         print("-" * 20)
#     return wrapper

# @outer
# def inner():
#     print("결과를 출력합니다.")

# inner()
# print(inner.__name__)




# # 데코레이터의 활용
# # 웹 페이지의 태그를 자동으로 생성해 주는 데코레이터

# def makeP(func) :
#     def wrap() :
#         return "<P>" + func() + "</P>"
#     return wrap

# def makeDiv(func) :
#     def wrap() :
#         return "<div>" + func() + "</div>"
#     return wrap

# @makeDiv
# @makeP
# def printTag() :
#     return "김범수"

# # print(makeP(printTag))
# print(printTag())







########## 인자를 받는 데코레이터

# def makeP(func) :
#     def wrap(name) :
#         return "<P>" + func(name) + "</P>"
#     return wrap

# def makeDiv(func) :
#     def wrap(name) :
#         return "<div>" + func(name) + "</div>"
#     return wrap

# @makeDiv
# @makeP
# def printTag(name) :
#     return name

# print(printTag("김범수"))


########여러함수에 사용

# def makeP(func) :
#     def wrap(*data, **param) :
#         return "<P>" + func(*data, **param) + "</P>"
#     return wrap

# @makeP
# def printTag(name, age, job, place) :
#     return name + str(age) + job + place

# @makeP
# def printP(prod, price) :
#     return prod + str(price)

# print(printTag("김범수", 39, "가수", "서울"))
# print(printP("키보드", 60000))






##########################################################3
# # 클래스 데코레이터
# # - 클래스의 객체를 호출 전, 호출 후로 수행하는 로직을 작성해 두는 기능
# #   . 메인 함수의 클래스 래핑

# class outer :
#     def __init__(self, func):
#         self.func = func
#     def __call__(self) :
#         print("****")
#         self.func()
#         print("****")

# @outer        
# def inner() :
#     print("결과를 출력합니다.")

# inner()







