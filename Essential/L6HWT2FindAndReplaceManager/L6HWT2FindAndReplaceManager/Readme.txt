Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге из примера урока 005_Delegation. 
При вызове этого метода, производится последовательный поиск строки в книге. 

Решение:
	+создать статический класс FindAndReplaceManager;
	+создать класс FindAndReplaceWorker;
	FindAndReplaceManager.cs:
		+создать метод void FindNext(string str):
			+реализовать делегацию с вызовом метода FindNext из класса FindAndReplaceWorker;
		+создать метод string ReplaceNext (string findStr, string replStr):
			+реализовать делегацию с вызовом метода ReplaceNext из класса FindAndReplaceWorker;
		+Создать метод вывода книги void Show;
			+реализовать делегацию с вызовом метода Show из класса FindAndReplaceWorker;
	FindAndReplaceWorker.cs:
		+Создать метод void FindNext(string str):
			+используя метод bool Contains проверить наличие str во всей строке;
		+создать метод string ReplaceNext (string findStr, string replStr):
			+используя статический метод Replace заменить найденые слова findStr на replStr;
			+вернуть новую строку;
	Program.cs:
		+Реализовать графическое меню для выбора действия пользователем (ввод строки, поиск, поиск и замена, выход)
		
			
			
