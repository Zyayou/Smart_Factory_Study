################################################################################
# # 사전(연관 배열) - 리스트 두개( key, value )를 연관시킨다.
# # - 키와 값의 쌍을 저장하는 대용량의 자료구조
# #   . 해시 알고리즘 ( 키에 맞는 값의 주소를 일정한 규칙에 의해 연결하는 함수)을 통하여 데이터가 등록되고 관리된다.
# #   . 해시 함수의 의존도가 높고, 공간 복잡도(메모리 손실 비용)가 증가한다. 
# #   . 리스트에 비해 검색 속도가 빠르다. (시간복잡도가 감소)
# #   . 리스트는 선형 탐색 구조 (처음부터 순차적으로 데이터를 확인)
# # - 키
# #   . 값을 찾는 기준
# #   . 중복되지 않는 고유한 값을 지님
# #   . 읽기 전용 속성, 변경할 수 없다.
# # - 값
# #   . 키에 할당되는 데이터
# #   . 데이터 변경이 가능하다.

# # 사전 포맷 { }
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# print(dic) # 사전 자료형 구조는 곧바로 호출해서 사용할 수 있다.
# print(dic['boy']) # 해당 키에 등록된 값을 확인할 수 있다.
################################################################################
# # get() : Key로 값을 찾음. 없으면 none을 반환 (null)

# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# print(dic.get('boy'))
# print(dic.get('boys')) # 시스템 오류를 반환하지 않는다. (값을 유동적으로 찾기에 용이)
# print(dic['boys']) # 오류



# # in을 통한 사전 데이터의 검색
# # in은 key의 데이터를 확인 할 수 있다.
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# if 'boys' in dic :
#     print("1. 데이터가 있습니다. : ", dic['boys'])
# elif 'boy' in dic : 
#     print("2. 데이터가 있습니다. : ", dic['boy'])



# # 사전의 데이터 수정, 추가, 삭제
# # 사전의 키가 있으면 update, 없으면 insert가 되어 갱신에 오류가 날 확률이 매우적다.
# # 시스템 오류가 발생 될 가능성은 낮지만, 오타 등의 이유로 데이터의 변질이 일어날 확률이 높다.
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# dic['boy'] = '남자아이'
# print(dic['boy'])

# dic['girl'] = '여자'
# print(dic)

# del dic['boy'] # 키와 값 데이터가 동시에 삭제
# print(dic)


# # key와 value를 목록으로 만들어 확인하기
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# print(dic.keys())
# print(dic.values())
# print(dic.items())


# # key 추출하여 출력
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# keylist = dic.keys()
# for key in keylist :
#     print(key)






# # 사전간 결합
# # 두 사전의 'book'키가 중복 되면 뒤따르는 사전에 있는 데이터가 updete
# dic = {'boy' : '남자', 'school' : '학교', 'book' : '책'}
# dic2 = {'girl' : '여자', 'dept' : '회사', 'book' : '서적'}
# dic.update(dic2) # dic1에 dic2 사전의 데이터를 덧붙인다. 중복은 허용 X 중복데이터는 후위 사전데이터로update
# print(dic)



# # 2차원 리스트, 튜플의 사전 변환
# # 다른 자료형 구조를 사전으로 변환, key와 value 쌍으로 구성되어 있으면 사전형태로 변환이 가능
# li = [['boy', '소년'],['book', '책']]
# dic = dict(li)
# print(type(li), li)
# print(type(dic), dic)

# tu = (('boy', '소년'),('book', '책'))
# dic = dict(tu)
# print(type(tu), tu)
# print(type(dic), dic)

# json형식 dic형식( 객체 자료형 ) 이라서 호환성이 높다.



################################################################################
# # 사전의 활용
# # 데이터의 빈도를 체크하는데 응용
################################################################################
# # 아래 노래 가사에서 각 단어 별 사용횟수 구하기
song = '''
Like an apple is my face
(사과 같은 내 얼굴)
How I look so beautiful
(예쁘기도 하구나)
Eyes are shiny nose is shiny
(눈도 반짝 코도 반짝)
And my lips are shiny
(입도 반짝 반짝 )
''' 

# # 빈 깡통 사전 만들기
# dicword = dict()
# for c in song : # 노래가사에서 글귀를 하나씩 추출
#     if c.isalpha() == False : #문자로 사용할 수 있는 단어인지 체크(영,숫,한) (빈 공백, 특수문자 제외)
#         continue
#     c = c.lower() # 소문자로 변경
#     if c not in dicword : # in , not in 은 사전의 키 값의 존재여부를 확인
#                           # 추출한 글귀로 구성된 키가 있는지 확인
#         dicword[c] = 1 # 사전에 포함되어 있지 않은 글귀라면 1을 부여, 신규생성
#     else : # 사전에 포함된 글귀라면 
#         dicword[c] += 1 # 1을 더해줌으로서 추가로 찾은 횟수를 증가
# print(dicword)




# # 사전으로 등록해둔 데이터를 순차적으로 정렬해서 표현하는 방법
# # 1. 리스트와 For를 사용
# keylist = list(dicword.keys()) # 사전의 키를 추출해서 list 로 형변환후 리스트 자료형에 할당
# keylist.sort() # 키가 담긴 리스트를 오름차순으로 정렬
# for w in keylist : # 키가 오름차순으로 정렬된 리스트에서 한 단어씩 추출 (a~z,ㄱ~ㅎ)
#     print(w, '=>', dicword[w])

# # 2. for를 사용 아스키코드 값을 사용한 range()를 사용
# # ord('a') : a의 아스키 코드 값(정수)  97
# # ord('z') +1 : a ~ z 까지 표현하기 위해 range 범위를 줄때 마지막 단어 코드 정수값 +1을 해줘야 포함된다.
# # chr(codevalue) : 코드 값(정수)를 문자로 변형
# for codevalue in range(ord('a'), ord('z')+1 ) :
#     word =chr(codevalue)
#     print(word, "=>", dicword.get(word, 0))





# # 실습
# # 위의 예제 에서 가장 많이 등장하는 문자 를 찾아 출력하세요
# dicword = dict()
# for c in song :
#     if c.isalpha() == False :
#         continue
#     c = c.lower() # 소문자로 변경
#     if c not in dicword : 
                          
#         dicword[c] = 1 
#     else : 
#         dicword[c] += 1 

# bigcount = max(dicword.values())
# for i in dicword :
#     if dicword[i] == bigcount:
#         print(i,":", bigcount)









################################################################################
# # 집합 set()
# # - 여러가지 값의 모임
# #   . 중복값 및 2개 이상ㅇ의 데이터 그룹을 비교 할 때 효과적
# #   . ( )로 표현, 사진처럼 ( : 'value' )가 포함되지 않는다
# #   . 원소들의 데이터는 일련적으로 나열되지 않는다.
################################################################################

# # 'korea' 원소는 중복된 데이터 이므로 집합에서 제외되어 표현된다.
# asia = {'korea', 'china', 'japan', 'korea'}
# print(asia)



# # 다른 잘형을 집합으로 변환
# # N개의 비교군을 자료혀으로 전달 받고 비교를 수행할 때 집합으로 변형 후 사용 가능
# print(set("Python"))
# print(set([22, 351,56,84])) # 리스트 -> 집합
# print(set(("김범수", "나얼", "박효신", "이수"))) # 튜플 -> 집합
# print(set({"a" : "에이", "b" : "비"})) # 사전 -> 집합 (키의 데이터만 집합으로 변형됨)


# # 집합의 생성과 데이터 등록 (초기화)
# test_set =  set() # 초기화(메모리에 등록되었을때)
# test_set = {'나비', '메미'}
# print(test_set)



# # 집합의 추가, 삭제
# Set = {'나비', '메미'}
# Set.add('풍뎅이')
# print(Set)
# Set.remove("나비")
# print(Set)
# Set.update({"사마귀", "물방개"})
# print(Set)



# # 집합의 종류와 연산처리
# set1 = {1,2,3,4,5,6,7}
# set2 = {3,5,7,8,9,10}

# print('교집합', set1 & set2 )
# print('합집합', set1 | set2 )
# print('차집합', set1 - set2 )
# print('배타적집합', set1 ^ set2 )



# # 부분집합과 포함 집합
# mammal = {"코끼리", "사자", "고릴라", "사람"}
# primate = {"사람", "고릴라"}

# print(primate <= mammal) # 포함하는지 확인 
# print(primate < mammal) # 포함하는데 나머지원소를 더 가지고 있는지 확인
# print(mammal <= primate) 
# print(mammal < primate) 
