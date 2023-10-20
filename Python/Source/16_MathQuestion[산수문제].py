#####################################################################
# # 임의의수 2개 덧셈 맞추기 
# import random
# a = random.randint(1,9) # 1~9 임의의 값
# b = random.randint(1,9)
# question = "%s + %s = " %(a,b)
# ans = int(input(question)) # 질/답 동기화
# if ans == a + b :
#     print("정답입니다.")
# else : 
#     print("틀렸습니다.")





#####################################################################
# # 임의의수 2개 덧셈 맞추기 
# # 반복해서 물어보되 0을 입력하면 프로그램 종료
# # 총 질문의 횟수와 정답의 횟수를 종료전 표현

# import random

# qustionCnt=0 #질문 횟수
# resultCnt=0 #정답 횟수
# while True :
#     qustionCnt += 1 # 질문 횟수 증가
#     a = random.randint(1,9) # 1~9 임의의 값
#     b = random.randint(1,9)
#     question = "%s + %s = " %(a,b)
#     ans = int(input(question)) # 질/답 동기화
#     if ans == 0 :
#         break
#     elif ans == a + b :
#         resultCnt += 1 # 정답 횟수 증가
#         print("정답입니다.")
#     else : 
#         print("틀렸습니다.")
# print("총 %d 문제 중 %d회 맞추셧습니다." % (qustionCnt, resultCnt))



#####################################################################
# # 임의의수 2개 임의의 사칙연산 맞추기 
# # 반복해서 물어보되 0을 입력하면 프로그램 종료
# # 총 질문의 횟수와 정답의 횟수를 종료전 표현

# import random

# qustionCnt=0 #질문 횟수
# resultCnt=0 #정답 횟수
# def rans() : #정답을 맞추었을 때
#     global resultCnt 
#     resultCnt += 1  # 정답 횟수 증가
#     print("정답입니다.")

# op = ['+', '-', '*', '/'] #임의로 추출할 사칙연산 기호
# while True :
#     qustionCnt += 1 # 질문 횟수 증가
#     a = random.randint(1,9) # 1~9 임의의 값
#     b = random.randint(1,9)
#     r = random.randint(0, len(op) - 1) 
#     question = "%s %s %s = " % (a,op[r],b)
#     ans = int(input(question)) # 질/답 동기화
#     if ans == 0 :
#         break
#     elif r == 0 and ans == a + b :
#         rans()
#     elif r == 1 and ans == a - b :
#         rans()
#     elif r == 2 and ans == a * b :
#         rans()
#     elif r == 3 and ans == a / b :
#         rans()
#     else : 
#         print("틀렸습니다.")
# print("총 %d 문제 중 %d회 맞추셧습니다." % (qustionCnt, resultCnt))







#####################################################################
# # 실습

# # 1. 0~ 100 까지 의 숫자 를 난수로 정하고 사용자가 난수를 맞추는 게임을 프로그래밍 해 보세요
# # . 틀렸을 경우 낮은 숫자인지 높은 숫자인지 결과 출력
# # . 맞추었을 경우 총 시도 횟수 와 함께 결과 출력
# import random as rand

# num = rand.randint(0, 100) # 0~100 랜덤 숫자
# tryCnt = 0 # 시도 횟수

# while True :
#     tryCnt += 1
#     ans = int(input("정답은? : "))
#     if ans > num :
#         print("보다 작습니다. 총 시도 횟수 :", tryCnt)
#     elif ans < num :
#         print("보다 큽니다. 총 시도 횟수 :", tryCnt)
#     else :
#         print("정답입니다.!!  총 시도 횟수 :", tryCnt)
#         break



# # 2. 위의 산수 문제 에서 실제 정답이 0 일 경우 정답인지 종료인지 정하는 메세지 와 함께 프로그램 의 종료 여부 를 정하는 로직을 구현해 보세요 

# import random

# qustionCnt=0 #질문 횟수
# resultCnt=0 #정답 횟수
# def rans() : #정답을 맞추었을 때
#     global resultCnt 
#     resultCnt += 1  # 정답 횟수 증가
#     print("정답입니다.")

# op = ['+', '-', '*', '/'] #임의로 추출할 사칙연산 기호
# while True :
#     qustionCnt += 1 # 질문 횟수 증가
#     a = random.randint(1,9) # 1~9 임의의 값
#     b = random.randint(1,9)
#     r = random.randint(0, len(op) - 1) 
#     question = "%s %s %s = " % (a,op[r],b)
#     ans = int(input(question)) # 질/답 동기화
#     if ans == 0 :
#         endq = input("종료하시려면 y를 입력해 주세요.")
#         if endq == 'y':
#             break
#     if r == 0 and ans == a + b :
#         rans()
#     elif r == 1 and ans == a - b :
#         rans()
#     elif r == 2 and ans == a * b :
#         rans()
#     elif r == 3 and ans == a / b :
#         rans()
#     else : 
#         print("틀렸습니다.")
# print("총 %d 문제 중 %d회 맞추셧습니다." % (qustionCnt, resultCnt))
