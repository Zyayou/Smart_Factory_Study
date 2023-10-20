#########################################################################
# # 파일을 다루는데 사용되는 모듈 shutil, os
# # 파일을 이동, 복사


# # 파일 복사의 예제
import shutil

shutil.copy("word.txt", "word2,txt")



##################
# # 절대경로 : 루트부터 파일의 이름까지를 나타낸 경로 (C:\user\a.exe)
# # 상대경로 : 특정 파일의 이름만 나타낸것 (a.exe)

# # 파일의 절대 경로를 문자열로 만들기
# import os

# # 현재 스크립트의 파일 경로
# script_path = os.path.abspath(__file__)

# # 현재 스크립트 파일이 위치한 디렉토리
# script_dir = os.path.dirname(script_path)

# # 파일의 절대 경로를 표현할 파일 상대 경로
# file_abs = 'word.txt'

# # 절대 파일 경로 만들어 주는 함수
# # 운영체제에 따라 파일르 경로를 지정하는 표현식이 다르다.
# # window : \ , max,unix : /
# # join시 절대 경로의 표현식을 운영체제에 맞게 표현해 준다.
# file_full_path = os.path.join(script_dir, file_abs)

# # print("특정 파일의 {0}의 절대경로 {1}".format(file_abs,file_full_path))
# print(F"특정 파일의 {file_abs}의 절대경로 {file_full_path}")



################### 파일 검색 및 출력하기 ####################################
# # 1. 폴더 내의 항목 검색 
# import os
# filelist = os.listdir(r"C:\Python\MP3")
# for file in filelist:
#     print(file)

# # 2. 함수의 재귀 호출을 통하여 폴더에 존재하는 (n개의 폴더 포함) 모든 mp3 파일 찾기
# import os

# # 폴더를 검색하는 함수, 모든 파일 찾아내기, 정렬하기
# def searchDir(dirpath) :
#     # 해당 폴더에 있는 모든 파일의 리스트 작성
#     filelist = os.listdir(dirpath)
#     for file in filelist :
#         fullpath = os.path.join(dirpath, file) # C:\Python\MP3\2022
#         # fullpath = dirpath + "\\" + file # C:\Python\MP3\2022
#         if os.path.isdir(fullpath) :
#             print("[" + fullpath + "]")
#             searchDir(fullpath) # 재귀함수 호출 : 더이상 폴더가 없을때 까지
#         else : # 절대 경로가 폴더 유형이 아닌경우
#             print("\t" + fullpath) # C:\Python\MP3\2022\a.mp3
    

# #폴더를 검색하기 위한 폴더 명칭을 인수로 전달
# searchDir(r"C:\Python\MP3")





# # 실습 
# # 위에 예제에서 메인폴더에 있는 항목은 들여쓰기 X

# import os

# # 폴더를 검색하는 함수, 모든 파일 찾아내기, 정렬하기
# def searchDir(dirpath) :
#     # 해당 폴더에 있는 모든 파일의 리스트 작성
#     filelist = os.listdir(dirpath)
#     for file in filelist :
#         fullpath = os.path.join(dirpath, file) # C:\Python\MP3\2022
#         # fullpath = dirpath + "\\" + file # C:\Python\MP3\2022
#         if os.path.isdir(fullpath) :
#             print("[" + fullpath + "]")
#             searchDir(fullpath) # 재귀함수 호출 : 더이상 폴더가 없을때 까지
#         elif dirpath == "C:\Python\MP3" :
#             print(fullpath) # C:\Python\MP3\a.mp3
#         else : # 절대 경로가 폴더 유형이 아닌경우
#             print("\t" + fullpath) # C:\Python\MP3\2022\a.mp3
    

# #폴더를 검색하기 위한 폴더 명칭을 인수로 전달
# searchDir(r"C:\Python\MP3")



#교수님 답안
# import os

# # 폴더를 검색하는 함수, 모든 파일 찾아내기, 정렬하기
# def searchDir(dirpath, ismain=True) :
#     # 해당 폴더에 있는 모든 파일의 리스트 작성
#     filelist = os.listdir(dirpath)
#     for file in filelist :
#         fullpath = os.path.join(dirpath, file) # C:\Python\MP3\2022
#         # fullpath = dirpath + "\\" + file # C:\Python\MP3\2022
#         if os.path.isdir(fullpath) :
#             print("[" + fullpath + "]")
#             searchDir(fullpath, False) # 재귀함수 호출 : 더이상 폴더가 없을때 까지
#         else : # 절대 경로가 폴더 유형이 아닌경우
#             if ismain :
#                 print(fullpath) # C:\Python\MP3\a.mp3
#             else :
#                 print("\t" + fullpath) # C:\Python\MP3\2022\a.mp3
    

# #폴더를 검색하기 위한 폴더 명칭을 인수로 전달
# searchDir(r"C:\Python\MP3")











############ 폴더내의 파일 명치 바꾸기 ################3
# # 예 : .mp3 파일의 가수와 제목의 명칭을 바꿔서 일괄 적용하기

# # 파일의 예 : 제목 - 가수 .mp3     윻ㅇ이 정형화 되어있습니다.

# import os

# filepath = r"C:\Python\MP3"
# # 파일 리스트 생성
# files = os.listdir(filepath)
# # 파일을 하나씩 추출하여 이름 바꾸기
# for file in files :
#     # '-'로 이름이 구분되고 확장자가 mp3인데이터만 처리
#     #   일정한 유형(패턴)으로 구성디어있는 파일들만 처리
#     if file.find('-') and file.endswith(".mp3") :
#         # 이름을 바꾸는 로직
#         # 1. 확장자 추출
#         ext = file[-4:]
#         # 2. 이름 추출
#         name = file[0:-4] # 0~-5 의 제목의 물자열을 가변적으로 담아온다
#         # 3. 가수와 제목을 분리할 패턴('-')을 이용하여 가수, 제목으로 데이터 나누기
#         namepart = name.split('-')
#         # 4. 가수와 제목의 위치를 바꾸고 기존 패턴으로 재적용
#         rename = namepart[1] + '-' + namepart[0] + ext
#         # 5. os모듈을 이용하여 실제파일의 이름을 변경 os.rename([바꾸기 전 파일 절대경로], [바꾼 후 파일 절대경로])
#         os.rename(filepath+"\\"+file, filepath+"\\"+rename)
#         # 6. 미리보기
#         print(filepath+"\\"+rename)


# # 실습
# # 재귀 함수를 이용하여 폴더 내의 모든 파일도 이름을 변경하는 로직을 완성해 보세요
import os

def searchDir(dirpath, ismain=True) :
    # 해당 폴더에 있는 모든 파일의 리스트 작성
    filelist = os.listdir(dirpath)
    for file in filelist :
        fullpath = os.path.join(dirpath, file) # C:\Python\MP3\2022
        # fullpath = dirpath + "\\" + file # C:\Python\MP3\2022
        if os.path.isdir(fullpath) :
            print("[" + fullpath + "]")
            searchDir(fullpath, False) # 재귀함수 호출 : 더이상 폴더가 없을때 까지
        else : # 절대 경로가 폴더 유형이 아닌경우
            if file.find('-') and file.endswith(".mp3") :
                # 이름을 바꾸는 로직
                # 1. 확장자 추출
                ext = file[-4:]
                # 2. 이름 추출
                name = file[0:-4] # 0~-5 의 제목의 물자열을 가변적으로 담아온다
                # 3. 가수와 제목을 분리할 패턴('-')을 이용하여 가수, 제목으로 데이터 나누기
                namepart = name.split('-')
                # 4. 가수와 제목의 위치를 바꾸고 기존 패턴으로 재적용
                rename = namepart[1] + '-' + namepart[0] + ext
                # 5. os모듈을 이용하여 실제파일의 이름을 변경 os.rename([바꾸기 전 파일 절대경로], [바꾼 후 파일 절대경로])
                os.rename(dirpath+"\\"+file, dirpath+"\\"+rename)
                if ismain :
                    print(fullpath) # C:\Python\MP3\a.mp3
                else :
                    print("\t" + fullpath) # C:\Python\MP3\2022\a.mp3

searchDir(r"C:\Python\MP3")
