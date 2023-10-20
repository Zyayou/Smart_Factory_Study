################################################################################
# # 문자열 (문자가 열거된 형태)
# # . 문자들을 일열로 나열시켜 순서에 맞게 index를 부여한 형태
################################################################################
# svalue = 'Python'
# print(svalue[2])
# print(svalue[-2])

# for char in svalue:
#     print(char, end='')


# # 문자열을 나타내는 범위를 지정하여 문자를 추출
# # len() : 열거형 데이터의 개수를 구할 수 있는 함수
# for index in range(1, len(svalue)) : 
#     print(svalue[index], end='')



# # 문자열의 index로 문자를 변경할 수 없다.
# svalue[1] = 'p'


################################################################################
# # 불변 객체 (immuteable)
# #  데이터를 새로 갱신하여 재배치하는 프로세스 보다 메모리 손실을 감안 하더라도
# # 새로운 메모리 영역에 데이터를 할당하는 것이 더 효율적이기 때문에 사용
################################################################################
# svalue = "안녕하세요"    # "안녕하세요" 메모리 등록
# svalue += "반갑습니다."  # "안녕하세요반갑습니다" 메모리 등록
# print(svalue)

# # string() 모듈
# # 불변객체인 str의 메모리 손실을 효율적으로 동작할 수 있도록 해주는 모듈
# # 다소 코딩이 복잡하지만 대용량의 데이터를 관리할 때는 필수(중요)
# from io import StringIO
# bf = StringIO()
# bf.write("안녕하세요")
# bf.write("반갑습니다.")
# result = bf.getvalue()
# bf.close()
# print(result)





################################################################################
# # 문자열 슬라이스 (범위 지정)
################################################################################
# svalue = 'Python.py'
# print(svalue[2:5]) # 2~4번째 인덱스 문자 추출 tho
# print(svalue[3:])  # 3~마지막 인덱스 문자 추출 hon.py
# print(svalue[:4])  # 0~3 index 까지 Pyth
# print(svalue[2:-3])# 2~ (-3 -1 )  = -4 index 까지 표현 thon
# print(svalue[-3:]) # -3 문자열부터 끝까지 표현 (확장자 추출) .py



# # 건너뛰면서 문자를 추출하는 기능
# print(svalue[::2])  # 0부터 2step :  Pto.y
# print(svalue[::-2]) # 마지막부터 -2step :  y.otP
# print(svalue[2::2]) # 2부터 2step 
# print(svalue[-2::2]) # -2 index 로 부터 2칸씩 들여써서 표현
# print(svalue[::-1])  # 문자열 반전
# print(svalue[2:8:2])  # 2~7까지 2step





################################################################################
# # 문자열 메서드
# # 문자열을 다룰 수 있도록 만들어 둔 클래스에서 제공하는 문자열 클래스의 기능(Function)
################################################################################
# svalue = 'Python Programming'
# # print(svalue.find('o')) # 0 index부터 가장 가까운 'o'의 index를 반환 , 없으면 -1 반환
# # print(svalue.rfind('og')) # 마지막부터 처음 나타나는 'og'의 'o' index를 반환
# # print(svalue.index('x'))  # 왼쪽에서 찾는다 없으면 오류  # ValueError: substring not found
# # print(svalue.count('n'))  # n 문자열의 갯수를 반환

# # 메서드가 반환하는 데이터 타입은 int
# print(svalue.count('n'), type(svalue.count('n')))

# # 2023.01 ~ 현재까지 안도잇 연령별 성비 확인
# # 통계 데이터에서 '남자' 데이터의 개수를 확인 할때 좋음
# if svalue.count('남자') > svalue.count('여자'):
#     pass






# # 문자열을 포함하는지 확인
# svalue = 'Python Programming'
# if 'P' in svalue :
#     print("대문자P는 포함되어 있습니다.")
# if 'p' not in svalue :
#     print("소문자p는 포함되어 있지 않습니다.")




# # 삼항 연산자 ( 조건의 참 / 거짓의 로직을 한줄로 표현 )
# # [참인 경우의 로직] if 조건else [거짓인 경우의 로직]
# svalue = 'Python Programming'
# print( 'm이 있습니다.'   if'm' in svalue  else 'm이 없습니다.' )




# # 해당 문자열로 시작 / 종료하는지 확인
# svalue = 'Python Programming'

# # startwith 시작하는지 확인
# print('Python 관련 데이터 입니다.' if svalue.startswith("Python") else "Python관련 데이터가 아닙니다.")
# # endswith 종료하는지 확인 (프로그램의 확장자를 찾을때 용이)
# print('jpg형식 입니다.' if svalue.endswith(".jpg") else "jpg형식이 아닙니다.")
