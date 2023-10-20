################################################################################
# # 가변 인자 (가변 인수)
# # - N개의 인수를 유동적으로받아서 처리하기
################################################################################
# # *ints 라는 가변인자 변수를 설정하여 intsum을 호출할때 N개의 인수를 전달하는 예시
# def intsum(*ints) : 
#     sum = 0
#     for num in ints :
#         sum += num
#     return sum
# print(intsum(1,2,3))






# #인수 인자 데이터 형식에 구애받지 않고 모두 수용하여 처리
# def intsum(*ints) : 
#     sum = 500
#     return sum
# print(intsum(1,True,10.1,"안녕하세요"))



# # 가변인자는 튜플 형태이며 임의로 수정할 수 없다.
# def intsum(*ints) :
#     ints[0] = 100
#     return ints[0]
# print(intsum(1,True,10.1,"안녕하세요"))









################################################################################
# # 가변인자의 위치
# # 반드시 인자 배열의 마지막 위치에 등록되어야 한다.
################################################################################
# # 담을 범위가 모호해 지므로 가변인자는 인자의 앞이나 중간에 올 수 없다.
# def intsum(*svalue, *snalue2) : # 가변인자, 가변인자 : 어디서부터 어디까지 1이고 2인 모호하기 때문에 안됨 
#     print("안녕하세요")
# intsum(1,2,3,4,5,6,7,8)


# # 가변인자는 앞에 위치할 수 없다.
# def intsum(*svalue, snalue2) : # 가변인자, 인자 : 어디서부터 어디까지 1이고 2인 모호하기 때문에 안됨 
#     print("안녕하세요")
# intsum(1,2,3,4,5,6,7,8)




# # 파이썬은 오버로딩 지원하지 않음
# # 오버로딩 : 같은 이름의 메서드(함수)를 인자의 구성에 따라 여러개 만들 수 있도록 하는 기능
# def intsum(svalue, *values) :
#     print(svalue, "첫 번째 함수")
# def intsum(svalue) :
#     print(svalue, "두 번째 함수")

# intsum("1")
# intsum("1",2,3,4,5)






################################################################################
# # 선택적 인수
# # 인자에 기본값을 주는 기능
# # 코드의 유지보수성을 향상시키기 위하여 사용
################################################################################
# # 선택적 인수 기능을 통하여 기존에 사용하던 로직은 수정하지 않고 유연하게 프로젝트를 유지보수할 수 있다.
# def sumCal(ivalue1, ivalue2, ivalue3) :
#     print(ivalue1 + ivalue2 + ivalue3)

# sumCal(10, 20, 0)
# sumCal(20, 30, 0)
# sumCal(10,20,30)


# def sumCal(ivalue1, ivalue2, ivalue3 = 0) :
#     print(ivalue1 + ivalue2 + ivalue3)

# sumCal(10, 20)
# sumCal(20, 30)
# sumCal(10,20,30)




# # 키워드 인수
# # 인자를 지칭하는 인수

# def sumCal(ivalue1, ivalue2, ivalue3) :
#     print(ivalue1 + ivalue2, ivalue3)

# sumCal(10, ivalue2=20, ivalue3=0)
# sumCal(20, ivalue3=30, ivalue2=0)
# sumCal(ivalue3=10,ivalue1=20,ivalue2=30)



################################################################################
# # 키워드 가변로직 (키워드 가변인수)
# # - 가변 인자에 변수명을 포함하여 전달하는 방법
# #  . 가변인자의 설정은 **[변수명]으로 한다.
# #  . 인ㄴ수의 키워드와 값은 각각 가변인자 튜플의 Key와 Value로 할당된다.
################################################################################
# # 키워드 가변인수의 예시
# def calstep(**params):
#     #키워드 가변인자의 속성 값
#     begin = params['begin']
#     end   = params['end']

#     sum = 0
#     # for num in range(begin, end+1 ,params[0]) : #인덱스로 호출할 경우 오류가 남
#     for num in range(begin, end+1 ,params['step']) :
#         sum += num
#     return sum

# print('범위의 합은', calstep(begin = 1, end = 100, step=2))



# # 가변인자와 키워드 가변인자의 혼용
def calstep(name, *score, **option) : 
    print(name)
    sum = 0

    for jumsu in score:
        sum += jumsu
    print("총점 : ", sum)

    if option['avg']== True :
        print("평균 : ", sum/len(score))

calstep("김범수", 90,80,80,90, avg=True)
calstep("이수", 70,80, avg=False)


