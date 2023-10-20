######################################################
# # 모듈
# # 파이썬 코드를 작성해 놓은 스크립트 파일, 함수, 변수, 클래스 등이 정의되어 있
# # . 누군가가 작성해둔 복잡한 로직을 활용하여 프로그램의 개발 생산성을 형상 시
# # . import : 외부모듈을 참조
######################################################

#### math 모듈의 import
# import math
# print(math.sqrt(2)) #2의 제곱근

#??
# # def sqrt(value) : 
# #     return value**2

# # print(sqrt(2))


#### from . import
# # math 모듈에서 sqrt함수만 사용
# from math import sqrt

# # # 사용할 때는 math를 붙이지 않아도 된다.
# print(sqrt(2))

# #### 모든 함수 참조하기
# from math import *
# print(sqrt(2)) #2의 제곱근
# print(log(2))



#########안해.




########################################### 현재 시각을 나타내는 모듈
# import time 

# print(time.time()) #1970년 1월 1일 자정 부터의 초

# # 현재 일시를 나타내기 
# t = time.time()
# print(time.localtime(t)) # 키와 값 형태의 데이터로 추출

# now = time.localtime(t)
# print("%d 년 %d월 %d일" % (now.tm_year, now.tm_mon, now.tm_mday))



# # 프로그램의 구동 시간을 확인
# import time
# start = time.time() # 시작시간
# for i in range(1,1000000) : 
#     i*i
# end = time.time() # 종료시간
# print("프로그램 구동시간 : ", end-start)



# # 프로세스의 일시정지
# import time 
# print("안녕하세요")
# time.sleep(1) # 1초간 프로세스 홀딩
# print("밤에 성시경이 두명있으면 뭘까요?")
# time.sleep(3)
# print("야간 투시경")



########################################################################
# # 달력 모듈 calender

# import calendar as c
#print(c.calendar(2021))


# import calendar as c
# yoil = ['월', '화','수', '목', '금','토','일']
# day = c.weekday(1995,8,15)
# print("1995년 광복절은 %s요일 입니다." % yoil[day])


########################################################################
# # 난수 Random
# # 임의의 수를 무작위로 생성하여 전달하는 모듈


# # 난수생성 함수
# import random as ran
# print(ran.random()) # 0 ~ 0.999999 까지는 난수생성
# print(ran.randint(1,10)) # 1 ~ 10 까지의 정수 난수 생성
# print(ran.uniform(1,100)) # 일정한 알고리즘을 통하여 난수의 결과를 반환
#                           # 데이터의 암호화를 작성할때 사용
#                           # 사작값 + (종료값 - 시작값) * 난수




# # 컬랙션에서 임의의 값을 추출하는 함수
# import random as ran
# food = ["자장면", "짬뽕", "탕수육", "군만두"]
# print(ran.choice(food))


# # randint() 와 randrange()
# import random as ran
# food = ["자장면", "짬뽕", "탕수육", "군만두"]
# i = ran.randint(0, len(food) -1) #randint는 이상 이하의 범위
# print(food[i])
# i = ran.randrange(len(food)) #randrange는 이상 미만의 범위
# print(food[i])


# # 리스트의 내용을 임의로 뒤섞기
# import random as ran
# food = ["자장면", "짬뽕", "탕수육", "군만두"]
# ran.shuffle(food) # 원본 리스트의 배열을 바꿈
# print(food)


# # # 임의의 6개 데이터 추출하기
# import random as ran
# num = [n for n in range(1,46)]
# print(ran.sample(num, 6))

