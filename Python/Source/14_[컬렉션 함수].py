




# lists = [10,20,30,40,50]
# iCnt = 0
# for num in lists :
#     iCin += 1
#     print( iCnt, "번째 숫자는 ", num)

# enumerate






#필기못함
################################################################################








# # N개의 컬랙션 합치키 Zip
# # 쌍이 맞는 개수 만큼만 반환
# yoil = ['월','화', '수', '목', '금', '토', '일']
# food = ['자장면', '볶음밥', '돈까스', '삼겹살']
# menu = zip(yoil, food) # yoil 리스트와 food리스트를 1:1로 매핑
# print(menu) # 데이터를 출력하는 기능 구현X
# for y,f in menu :
#     print("%s요일의 음식은 %s입니다." % (y, f))



# # zip객체를 딕셔너리로 변환하기
# yoil = ['월','화', '수', '목', '금', '토', '일']
# food = ['자장면', '볶음밥', '돈까스', '삼겹살']
# menu = dict(zip(yoil, food) )# yoil 리스트와 food리스트를 1:1로 매핑
# print(menu) # 데이터를 출력하는 기능 구현



# # Any() 와 All()
# # any() : 하나라도 True 이면 True
# # all() : 모두가 True 이면 True
# lists = [True, True, False]
# print(any(lists))
# print(all(lists))


# # filter()
# # 함수와 리스트를 인자로 전달 받아서 True인 결과만 리스트로 생성하여 반환
# # . 함수의 return은 True/False여야한다.
# def MyFunction(s) :
#     return s < 60 # bool반환

# lists = [10,20,30,40,50,60,70,80]
# lists2 = filter(MyFunction, lists)
# print(lists2) # 출력기능이 구현되어 있지 않으
# for value in lists2 :
#     print(value, end=' ')




# # map()
# # 함수와 리스트를 인자로 받아서 연산의 결과를 리스트로 생성
# def half(s) :
#     return s/2
# score = [45,46,47,48,48,50]
# for value in map(half, score) :
#     print(value, end=', ')

# # map()을 이용한 연산처리 예제
# def F_sum(v1, v2) :
#     return v1+v2

# score1 = [45,46,47,48,48,50]
# score2 = [22,33,44,55,66,77]
# for value in map(F_sum, score1, score2) :
#     print(value, end=', ')


# # fshjgrke;flfjklfdkfak;slfdjfdjkfdzd
# # 무명메서드ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ
# # 람다 : 함수의 이름의 제외한 메서드 시그니처만 가지고 기능을 할 수 있도록 도와주는 기능




########################################################################
# # Lambda
# # 이름이 없는 메서드(무명 메서드)를 간결하게작성해서 사용할 수 있도록 하는 문법(기능)
# # . 재사용하지 않는 로직일 경우(2번이상 사용X) 메서드(함수)를 굳이 작성할 필요 X
# # . 함수를 전달받는 인자가 있을경우 재사용을 하지 않은 메서드는 함다로 간결하게 무성하여 전달할 수 있다.
########################################################################
# # 메서드(함수)의 시그니처
# # 메서드(함수)의 이름을 제외한 인자유형, 반환유형을 메서드의 시그니처 라고 한다.
# # 람다는 함수의 이름을 제외하고 함수를 전달 받는 인자에게 메서드의 시그니처만 전달하는 유형

# # # 람다의 구현 예제
# def Myfunction_anClass(func, v1, v2) : # 외부에서 작성한 개발자가 접근할 수 없는 메서드 (함수)
#     return func(v1, v2)

# # # Myfunction_anClass를 사용하는 개발자가 호출할 때
# def my(v,s) : 
#     return v + s
# #print(Myfunction_anClass(my,10,20))
# # # 함수를 만들 필요 없이 람다로 생성하여 호출한다.
# print(Myfunction_anClass(lambda x,y : x+y , 10, 20))


# # filter 함수의 lambda
# # 함수를 받기로 약속되어있는 클래스

# score = [10,20,30,40,50]
# for num in filter(lambda x : x%8 == 0, score) :
#     print(num)






###########################################################################################
# # 실습
# # 아래 map 클래스의 기능을 f_sum 함수를 사용하지 않고 lambda를 통해 간략히 구현해 보시요
###########################################################################################
# # def F_sum(v1, v2) :
# #     return v1+v2

# # score1 = [45,46,47,48,48,50]
# # score2 = [22,33,43]
# # for value in map(F_sum, score1, score2) :
# #     print(value, end=', ')

# score1 = [45,46,47,48,48,50]
# score2 = [22,33,43]
# for value in map(lambda x,y : x+y, score1, score2) :
#     print(value, end=', ')
















###########################################################################################

####### 리스트의 얕은 복사
# # 리스트를 직접 변수에 할달할 경우 참조형식으로 데이터 주소를 전달한다.
# # 원본과 데이터를 공유한다.
# score = [45,50,4,5,6,7,9]
# score_back = score
# score_back[0] = 10
# print(score_back)
# print(score) # 얕은 복사로 인해 원본 데이터도 변질됨

####### 리스트의 깊은 복사
# score = [45,50,4,5,6,7,9]
# score_back = score.copy() # 원본리스트의 깊은복사
# score_back[0] = 10
# print(score_back)
# print(score) # 깊은 복사로 인해 원본 데이터 변질을 막을 수 있다.


####### 중첩 리스트의 깊은 복사
# import copy # 복사를 위한 상세한 기능이 모여있는 외부 모듈

# score = [45,[10,20,30],4,5,6,7,9]
# # score_back = score.copy() # 중첩 리스트의 경우 copy()메서드로는 깊은 복사를 할 수 없다.
# score_back = copy.deepcopy(score)
# score_back[1][1] = 0
# print(score_back)
# print(score) # 깊은 복사로 인해 원본 데이터 변질을 막을 수 있다.





###################### 같은 메모리를 참조 하고 있는지 (같은 메모리 주소를 공유하고 있는지) 확인
# # is 연산자
# list1 = [10,20,30]
# list2 = list1
# list3 = list1.copy()

# print("list1 과 list2는 같은 주소를 바라보고 있나요?", list1 is list2)
# print("list2 과 list3는 같은 주소를 바라보고 있나요?", list2 is list3)
# print("list1 과 list3는 같은 주소를 바라보고 있나요?", list1 is list3)




####################### 변수의 참조 변경
# # str, int 유형의 데이터는 값 형식
# # 파이썬의 경우 값 형식이더라도 데이터 주소를 공유
# a = '가'
# b = a
# print("a, b 같은주소 ? ", a is b)
# b = '나'
# print(a)
# print(b)
# print("a, b 같은주소 ? ", a is b)










###########################################################################################
# # 실습
# # 1. 1 ~ 10 정수의 리스트 a 와 각 정수의 제곱 리스트 b 를 만든 후 두 리스트 를 합쳐 사전으로 만든후 사전에서 6의 제곱값을 
# #    검색하여 출력하는 로직을 구현해 보세요
a = [1,2,3,4,5,6,7,8,9,10]
b = []
for i in a :
    b.append(i*i)
dic = dict(zip(a,b))
print(dic)
print(dic[6])

# # 2. price 리스트에 상품 가격 네개가 저장 되어 있다. 함수 와 리스트를 map 을 사용하여
# #    모든 상품 가격을 20% 세일한 값으로 출력 하는 로직을 구현해 보세요
price = [1000,12000,5000,8000]
sale = map(lambda x : x*80/100, price)
for i in sale :
    print(i, end=' ')