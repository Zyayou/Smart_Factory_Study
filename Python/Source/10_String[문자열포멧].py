################################################################################
# # 포멧팅 : 문자열 안에 세부 정보를 포함하여 출력하도록 명령하는 기능
# # . 문자열 사이에 특정정보를 삽입하여 하나의 문자열을 만들어 내는 기능
################################################################################
# # 표식의 사용예제
# station = "구로"
# direction = False

# print("이번역은 %s 입니다. 내리실 문은 %s 입니다." %(station, "왼쪽" if direction == True else "오른쪽"))


# # 문자열의 서식
# # 정렬을 지정
# value = 123
# print("###%d###" % value)   ###123###
# print("###%5d###" % value)  ###  123##
# print("###%3d###" % value)  ###123###  #이미 3칸차지


# # 숫자의 경우 오른쪽 정렬이 기본 
# price = [30,13500,2000]
# for p in price:
#     print('가격 : %10d원' %p)
# for p in price:
#     print('가격 : %-10d원' %p) #왼쪽정렬



# # 실수의 포멧
# pie = 3.141592
# print("%8f" %pie)
# print("%8.3f" %pie) # 총 8개의 실수를 표현하는데 소스점 4자리에서 반올림
# print("%-8.3f" %pie) # 총 8개의 실수를 표현하는데 소스점 4자리에서 반올림, 왼쪽정렬





################################################################################
# #  신형 포멧팅 ( 문자열의 보간 : 누락 / 빈곳을 채워넣음.)
################################################################################
# # { } 중괄호 내의 문자열 가공
# id          = "ADMIN"
# MailAddress = "cleverdsh@gmail.com"
# Name        = "관리자"

# print("이름 : {} , ID : {} , 메일주소 : {} ".format(Name, id, MailAddress))



# # index를 통해 인수의 순서를 배치 할 수 있다.
# id          = "ADMIN"
# MailAddress = "cleverdsh@gmail.com"
# Name        = "관리자"

# print("이름 : {2} , ID : {1} , 메일주소 : {0} ".format(MailAddress, id, Name))



# # { } 중괄호 안에 변수 이름을 적어두고 키워드로 값을 나열할 수 있다.

# print("이름 : {Name} , ID : {id} , 메일주소 : {MailAddress} ".format(MailAddress = "cleverdsh@gmail.com", 
#                                                        id          = "ADMIN", 
#                                                        Name        = "관리자"))



# # Key와 Value를 가지는 자료형(Dic)을 생성하여 매핑할 수 있다.
# # ID, Name, Maileaddress를 관리하는 3개의 요소가 등록된 사전
# User = {'ID'          : "ADMIN", 
#         'Name'        : "관리자",
#         'MailAddress' : "cleverdsh@gmail.com" }
# print("이름 : {0[Name]} , 아이디 : {0[ID]} , 메일주소 : {0[MailAddress]}".format(User))



# # 서식 지정
# Age = 24 
# Name = "관리자"
# Height = 177.12 
# print("이름 : {2:10s} , 아이디 : {0:5d} , 메일주소 : {1:8.2f}".format(Age, Height, Name))





################################################################################
# # 실습
################################################################################
# # 1. "차종 : 코란도C, 제조사 : 쌍용, 배기량: 1998" 문자열에서 "제조사" 만추출하여 출력하세요.
# info = "차종 : 코란도C, 제조사 : 쌍용, 배기량: 1998"
# print(info[17:19])

# # 2. 임의의 주민등록번호 13 자리를 입력받아 현재 나이 와 성별을 출력하는 프로그램을 작성해 보세요
# #  - '-' 를 제외 한 숫자를 입력하지 않은 경우 예외 처리 한다.
# #  - 13자리 를 입력하지 않은경우 의 예외상황 처리 한다.
# #  - 정확한 결과를 출력할때까지 반복한다


while True :
    info = input("주민등록번호 13자리를 입력해 주세요 : ")
    info = info.replace('-', '').replace(" ","")
    if not info.isnumeric() :
        print("숫자와 '-'만 입력해 주세요.")
        continue
    if not len(info) == 13 :
        print("13자리 숫자를 입력해 주세요")
        continue
    

    if info[6] == '1':
        age = 2023 - (1900+int(info[:1])) -2
        print("남자 %d살 입니다." %age)  
        break
    elif info[6] == '3' :
        age = 2023 - (2000+int(info[:1])) -2
        print("남자 %d살 입니다." %age)  
        break
    elif info[6] == '2' :
        age = 2023 - (1900+int(info[:1])) -2
        print("여자 %d살 입니다." %age)
        break
    elif  info[6] == '4' :
        age = 2023 - (2000+int(info[:1])) -2
        print("여자 %d살 입니다." %age)
        break
    else:
        print("올바른 주민번호가 아닙니다.")
        continue
    


# # 교수님 코드
while True:
    identity = input("주민등록 번호 를 입력 하세요: ").replace("-","").replace(" ","")
    
    ###################### 벨리 데이션 : 검증 로직 먼저 수행 #############################
    if not identity.isnumeric() : # 숫자를 입력 하지 않은 경우 리턴
        print("숫자 만 입력하세요")
        continue
    #### 숫자 만 입력되어있는 상태
    if len(identity) != 13 :
        print("주민등록 번호 는 13자리를 입력하세요.")
        continue
    ####################################################################################

    # 정상 적으로 데이터를 받았기 때문에 비교하는 로직 
    result = "성별 : "
    sung = identity[6] #9000001111111
    if sung == "1" or sung == "3" : result += "남자"
    elif sung == "2" or sung == "4" : result += "여자"
    else : 
        print("성별을 확인할 수 없습니다.")
        continue
    age = int(identity[:2]) #9000001111111
    result += " %d 살입니다." %  (23 + (100 - age))   if age > 23 else    (23 - age)
    print(result)
    break
