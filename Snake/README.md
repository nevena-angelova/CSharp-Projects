<h1>Snake - конзолна игра</h1>

Към играта допълнително за добавени животи, създване на нови ябълки на случайни позиции през определен интервал от време, препятствия, появяващи се на случаини позиции през определен интервал от време, изписване на крайното класиране по точки от всички изиграни игри.

I. Начални етапи при реализирането на играта:

1.	Създаване на структура (Position), съдържаща променливи x и y , използвана за записване на координати.
2.	Създаване на змията – използва се Queue, съдържаща елементи от тип Position. Задава се начално състояние (дължина и позиция на змията). 
Създаване на променлива от тип Position за ябълката със случайно генерирана начална стойност.
Създаване на List от тип Position, където се добавят препядствията.
3.	Създаване на масив , съдържащ посоките на движение на змията.

II. Функционалност

1.	Движение на змията
При натиснат бутон от клавиатурата, се проверява дали той е някоя от стрелките.
Движението на змията става чрез добавяне и махане на по един елемент в началото и в края и. Новият добавен елемент се получава чрез събирането на координатите на текущата „глава” на змията с координатите на посоката, съответстваща на натиснатата стрелка.
2.	Изяждане на ябълката
Ако координатите на ябълката съвпаднат с тези на главата на змията, се генерира нова, точките се увеличават, а от опашката на змията не се вади елемент, с което змията расте с по един елемент при всяко изяждане на ябълка.
3.	Генериране на ябълка и препятствия на случайни позиции през определен интервал от време
startAppleCount и startObstaclesCount приемат за първоначални стойности секундите от започването на програмата преди влизането в while цикъла. endAppleCount и endObstaclesCount взимат секундите при всеки изминал етап от цикъла. Ако разликата между началните и крайните стойности стане равен на желания интервал, се създава съответния елемент от тип Position, startAppleCount и startObstaclesCount приемат текущите секунди, за да се нулира отброяването.
 Генеринането на елементи стaва чрез задаване на произволни координати x и y с помощта на Random Generator.
При създаването на ябълки и препятствия се прави проверка дали координатите им не съвпадат или дали не са същите с тези на змията.
4.	Изчертаване на елементите
Предимно се използва метода Draw – курсорът се установява на позиция с коодринати равни на стойностите на x и y на дадения Position елемент, на тази позиция се изчертава символ с определен цвят.  
5.	Край на играта
Използвано е изключението, което се хвърля при изчертаването на змията, ако  тя попадне извън рамките на конзолата. Допълнително се хвърля изключение ако координатите на главата на змията съответстват с тези на тялото и, или на някое от препятствията.  Ако животите са по-големи от нула намаляват, на змията се задават началните координати, на  startObstaclesCoun се задават текущи стойности. Когато животите свършат, конзолата се изчиства, изписва се „Край на играта”, изкараните точки и сортираните резулатати от всички изиграни игри.
За запазване на всички точки се ползва отделен текстов фаил. Разгледани са изключенията при четене на текстови файлове.