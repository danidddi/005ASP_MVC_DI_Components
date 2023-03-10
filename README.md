# 005ASP_MVC_DI_Components

Теоретическая часть
•	Привязка простых данных к методу действия контроллера
•	Привязка сложных типов данных
•	Привязка коллекция
•	Задание источника для привязки данных к методу действия
•	Понятие о компонентах представлений
•	Создание компонентов и применение компонентов в разметке
•	POCO-компонент (Plain Old CLR Object)
•	Построение компонента как расширение класса ViewComponent
•	Типы результата метода Invoke() компонентов представлений
•	Размещение разметки компонента представления – в папке представлений контроллера или в папке _Shared
•	Передача параметров в компонент (в метод Invoke()) из представления
•	Асинхронные компоненты
•	Гибридные компоненты – контроллер с методом Invoke() и атрибутом ViewComponent (повторим этот материал 25.08.2022)  
Практическая часть
Создать приложение ASP.NET Core MVC. Стилизацию приложения выполняйте при помощи фреймворка Bootstrap. Примените страницу компоновки. Не забывайте создавать модель/модели для решения задачи. По GET-запросу /Home/Index выводите этот текст. 
Требуется получать коллекцию пользователей используя ресурс по запросу https://jsonplaceholder.typicode.com/users/. Сохранять в коллекции поля: id, name, username, email, phone, website. Коллекцию выводить в компонент представления, коллекцию получайте сервисом. Компонент и сервис рекомендуется сделать асинхронными.
•	По кнопке на отдельной странице вывести все посты пользователя (запрос вида https://jsonplaceholder.typicode.com/users/2/posts где 2 - идентификатор пользователя), вывод при помощи компонента представления, в этом же компоненте выводить количество постов, минимальную, среднюю и максимальную длина текста (поле body) в символах
•	По кнопке на отдельной странице вывести фото из альбома пользователя (запрос вида https://jsonplaceholder.typicode.com/albums/1/photos  где 1 – идентификатор пользователя, выводить поле thumbnailUrl), в этом же компоненте выводить количество фотографий в альбоме (это обработка компонента)
•	По кнопке на отдельной странице вывести список дел пользователя (запрос вида https://jsonplaceholder.typicode.com/users/3/todos где 3 – идентификатор пользователя), в этом же компоненте выводить количество дел, количество завершенных и не завершенных дел
Разработайте сервис логирования, сохраняющий в файле application.log в папке App_Data факты создания и редактирования сведений о клиентах: момент времени операции с точностью до секунды, собственно данные клиента (включая закодированный пароль).
Разработайте глобальный фильтр исключений – сервис с внедрением зависимостей. Параметры исключений записывайте в файл журнала при помощи сервиса логирования.
Дополнительно
Запись занятия можно скачать по этой ссылке, материалы занятия в этом же архиве.
