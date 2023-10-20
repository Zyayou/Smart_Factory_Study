# # 문자열의 변경
# # 특정 문자를 변경하는 기능
# svalue = "Visual Studio Code를 이용한 Python Course"
# print(svalue.lower()) #소문자로 변경
# print(svalue.upper()) #대문자로 변경
# print(svalue) # lower나 upper() 메서드를 사용해도 원본데이터는 변하지 않는다.

# print(svalue.swapcase()) # 대소문자로 스위칭
# print(svalue.capitalize()) # 문자열의 첫 영문자만 대문자
# print(svalue.title()) #문자열의 문단별로 첫 영문자 소문자(카멜롯 표기법)



# # 대 / 소문자 변경 기능의 활용
# # 로그인 기능 시 대 / 소 문자를 구별하고 싶지 않을때
# # 프로그램은 대 / 소문자를 구별하지만 사용자는 대 / 소문자를 다른 문자로 인식하지 않는다.
# # 로그인 기능

# dbUserID = "admin" # 데이터 베이스에 등록되어있는 사용자 아이디

# while True :
#     userid = input("사용자 ID를 입력하세요 : ").lower()
#     if userid.lower() == "admin" :
#         print("admin님 반갑습니다.")
#         break
#     else :
#         print("IP가 잘못되었습니다.")


# # 공백  제거
# svalue = "        Python            "
# print(svalue.lstrip(), '좋아요') # 문자열 왼쪽의 모든 공백 제거
# print(svalue.rstrip(), '좋아요') # 문자열 오른쪽의 모든 공백 제거
# print(svalue.strip(), '좋아요') # 문자열 왼/오른쪽의 모든 공백 제거


# # 문자열의 분할 ***
# # split() : 특정 문자열을 기준으로 나눈 문자열을 리스트로 변환
# svalue = "Python C# C Java JavaScript"
# print(svalue.split()) # () : 빈 공백을 기준을 나눈다

# # 특정문자를 기준으로 나눌때
# svalue = "안녕하세요, 반갑습니다."
# print(svalue.split(','))

# # 문자열이 개행되는 시점으로 나뉠때
# svalue = "안녕하세요\n반갑습니다."
# print(svalue.splitlines())

# # 문자열을 하나로 합칠때 join() <-> split()
# svalue = "Python, C#, C, Java, JavaScript"
# lists = svalue.split(',')
# print(lists)
# print(' '.join(lists)) # 특정한 기준으로 결합

# # 특정문자열을 원하는 문자열로 변경 replace()
# svalue = "안녕하세요 ㅇㅇㅇ입니다."
# print(svalue)
# print(svalue.replace("ㅇㅇㅇ","김범수"))


# # 문자열에 공백을 추가하여 정렬
# message = "Hello Python" # 12 글자
# message2 = "VsCode"  # 6글자
# print(message.ljust(30), ":")
# print(message.rjust(30), ":")
# print(message.center(30), ":")
# print(message2.center(30), ":")







################################################################################
# # 실습
################################################################################
# # 안녕하세요 2023 안동대학교 스마트팩토리 S/W 개발 교육과정을 이수하게 된 OOO 입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으면 합니다.
# # 1. OOO (대문자 o) 본인이름 변경 후 출력
# # 2. S/W 글자위치 찾아서 출력
# # 3. 시작 단어와 마지막 단어 1자씩 출력
# # 4. 문자의 앞 뒤에 '-KDT-' 입력
# # 5. 'DIGITALTRANING' 글자만 소문자로 변경한 후 출력
# # 6. 모든 위치의 공백 없앤후 출력
# # 7. . (문단) 을 기준으로 행을 나눠서 출력
# # 8. 7에서 나눈 문단을 좌우 공백을 일정하게 둔 가운데 정렬로 표현
svalue = "안녕하세요 2023 안동대학교 스마트팩토리 S/W 개발 교육과정을 이수하게 된 OOO 입니다. 즐겁고 보람찬 DIGITALTRANING 교육이 되었으면 합니다."
print("1.")
lines = svalue.replace("OOO", "조은경")
print(lines)

print("2.",svalue.find("S/W"))

print("3.",svalue[0],svalue[-1])

print("4.", "-KDT-", svalue, "-KDT-")

print("5.",svalue[:svalue.find("DIGITALTRANING")] + svalue[svalue.find("DIGITALTRANING"):].lower())
# 교수님 답변 
# print("5.",svalue.replace("DIGITALTRANING","DIGITALTRANING".lower()))

print("6.")
lines = svalue.split()
for i in lines:
    print(i, end="")
print("")
# 교수님 답변 # 
# lines = svalue.replace(" ","")
# print(lines)

print("7.")
lines = svalue.split(".")
for i in lines[:-1]:
    print(i.lstrip()+".")

print("8.")
for i in lines[:-1]:
    message = (i.lstrip()+".")
    print(message.center(70))
