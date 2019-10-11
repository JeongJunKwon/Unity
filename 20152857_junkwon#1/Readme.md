과제1 
자동차(플레이어)를 마우스로 클릭하여 우측으로 움직여 깃발에 가장 가까이 보내는 게임 [2D/3D]
. 자동차, 깃발, 배경, 자동차와 깃발 사이의 거리 표시
. 플레이어/깃발/배경 이미지는 게임 구성에 따라 다양한 형태로 변경 가능

구현 내용
- PlayerScript
	- 마우스를 클릭하면, 마우스 위치의 x좌표를 startPos 변수에 저장
	- 마우스를 떼면, 마우스 위치의 x좌표를 endPos 변수에 저장 후 
	- endPos와 startPos의 차를 speed 변수에 추가(그냥 빼면 속력이 너무 나가기 때문에 500.0f로 나눔)
	- player의 transform 컴포넌트에 Translate 메소드를 사용하여, x좌표를 증가함
	- 속력은 거리를 가면서 줄어들기 때문에 0.98씩 곱해나감.
- GameDirector
	- player, flag, distance의 gameobject를 이름으로 찾음
	- flag 오브젝트의 x좌표와 player의 x좌표 차를 length 변수에 저장
	- 만약 length가 1보다 크다면, distance 오브젝트의 text 컴포넌트에 player와 flag의 거리차를 ToString()으로 변환
	- 만약 length가 1보다 작다면, distance 오브젝트의 text 컴포넌트에 GameOver!를 표시
	
과제2
캐릭터(플레이어)가 화살/장애물 등을 피하는 게임 [2D/3D]
  . 캐릭터, 화살(장애물), 배경
. 캐릭터 라이프(숫자 / 이미지로 표시, 화살을 맞으면 낮아지고 0이면 게임 종료)
. 좌우이동키(이미지로 표현 / 특정키 값 영문 R, L / 키보드 좌우 이동키)
. 플레이어/장애물/배경 이미지는 게임 구성에 따라 다양한 형태로 변경 가능

구현 내용
- PlayerScript
	- 변수
		- gameDirector: GameDirector 오브젝트를 찾음
	- 메소드
		- void onLeft() 
			- player의 x좌표가 -2.5f보다 작다면, Can't Move 디버그를 로그, 아니라면, Vector2.left만큼 x좌표 이동
		- void onRight()
			- player의 x좌표가 2.5f보다 크다면, Can't Move 디버그를 로그, 아니라면, Vector2.right만큼 x좌표 이동
		- void OnTriggerEnter2D(Collider2D other)
			- gameDirector의 GameDirector 스크립트의 DecreaseHeart() 메소드를 호출
	- update()
		- 오른 화살표가 눌리면, onRight() 메소드 호출
		- 왼 화살표가 눌리면, onLeft() 메소드 호출
		
- ArrowScript
	- 메소드
		- Start()
			- rnd 변수에 -2.5f ~ 2.5f의 변수 생성
			- 스크립트를 가지는 object의 위치를 Vector3(rnd, 3.0f, 0.0f)로 이동
		- Update()
			- object의 위치를 Vector3.down * Time.deltaTime만큼 이동
			- object의 y좌표가 -3.0f보다 작다면, object를 파괴
		OnTriggerEnter2D(Collider2D other)
			- object를 파괴
- ArrowGenerator
	- 변수
		- GameObject arrow
		- float time
		- bool isTimeOut
	- 메소드
		- Start()
			- isTimeOut 변수에 false 할당
		- Update()
			- isTimeOut 변수가 거짓이라면, arrow 오브젝트를 생성하고, isTimeOut을 true로 변경
			- time 변수는 매초 1씩 빼지며, time이 0보다 작아지면, isTimeOut 변수를 false로 변경
			- 2초마다 arrow 오브젝트를 생성한다.
- GameDirector
	- 변수
		- List<GameObject> hearts
		- GameObject heartArr
		- bool isOver
		- int life
		- Text gameoverText
	- 메소드
		- Start()
			- hearts 이름을 가진 gameObject를 heartArr로 지정하고, hearts 리스트에 추가해준다.
			- isOver 변수를 false로 변경하고, life를 hearts의 길이 - 1로 설정
			- gameoverText가 가리키는 gameObject를 찾고, Text 컴포넌트에 연결
		- Update()
			- hearts가 비게 되면, isOver 를 true로 변경
			- isOver가 true면 gameOverText에 gameOver를 쓰고, timeScale을 0으로 변경
		- DecreaseHeart()
			- hearts[life]에 해당하는 gameObject를 파괴
			- hearts의 life번째 object 제거
			- life에 1을 뺌