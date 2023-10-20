######################################################################################
# # 예외처리
# # try / except
# # . 프로그램을 실행할 때 개발자가 미연에 알아차리지 못한 오류나 사용자의 예외 데이터 입력 상황, 통신 규약에 맞지 않는 데이터의 전송
# #   등의 예외 상황을 유연하게 대처하고 프로그램의 유지 보수를 도와준다. 
# # . 사용자에게 시스템 오류를 노출하지 않고 올바르게 로직을 처리할 수 있게 하여 프로그램의 신뢰성을 높이고 사용자에게 올바른 사용을 유도할 수 있다.
######################################################################################

# # try, excapt의 기본 용법
# while(True) :
#     # 정수로 문자를 입력할수도 있는 상황
#     ivalue = input("점수를 입력하세요")
#     try :
#         # 입력받은 내용을 정수로 형변환
#         score = int(ivalue)
#     except :
#         print("정수만 입력해 주세요.")


# # except의 종류
# # Excetion : 예외 상황의 최상위 클래스. (모든 예외상황을 검출할 수 있다.)

# ivalue = input("점수를 입력하세요")
# score = 0
# try :
#     # 입력받은 내용을 정수로 형변환
#     score = int(ivalue)
# # except TypeError : # 데이터 타입 형 변환에 샐패 하였을 경우
# #     print("타입 형변환에 실패")
# #     score = 20
# # except Exception : # 에러 클래스의 최상위 검출 클래스
# #     print("타입 형변환에 실패")
# #     score = 20
# except ValueError : # 값의 형식을 잘못 입력하였을 경우
#     print("값 형식을 잘못 입력하였습니다.")
#     score = 100
# print("입력 :",score)





# # 예외 상황의 강제 발생ralise
# ivalue = input("점수를 입력하세요")
# score = 0
# try :
#     # 입력받은 내용을 정수로 형변환
#     score = int(ivalue)
#     if score > 100:
#         raise Exception("100보다 큰 수는 입력할 수 없습니다.")
# except Exception as ex :
#     print(ex)
#     score = 20
# except ValueError : # 값의 형식을 잘못 입력하였을 경우
#     print("값 형식을 잘못 입력하였습니다.")
#     score = 100
# print("입력 :",score)






# # finally
# ivalue = input("점수를 입력하세요")
# score = 0
# try :
#     # 입력받은 내용을 정수로 형변환
#     score = int(ivalue)
#     if score > 100:
#         raise Exception("100보다 큰 수는 입력할 수 없습니다.")
#     print("데이터 저장완료 commit")
# except Exception as ex :
#     print(ex)
#     score = 20
# except ValueError : # 값의 형식을 잘못 입력하였을 경우
#     print("값 형식을 잘못 입력하였습니다.")
#     score = 100
# finally :
#     print("DB 접속 차단")
# print("입력 :",score)





### 예외상황의 검출 Assert
# # try / except를 간결하게 처리할 수 있도록 줄인 구문
# # 특정 시점의 예외 상황을 발생시켜 로직을 검증할 때

# value = input("점수를 입력하세요")
# try:
#     score = int(value)
#     # 100이하가 아니라면 예외상황을 발생
#     assert score <= 100 , "94행 : 점수 범위 초과"
# except ValueError :
#     print("타입형")
#     print("데이터 복수 rollback")
#     score = 20
# except AssertionError as ae :
#     print(ae)
# print(score)