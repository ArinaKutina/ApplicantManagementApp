# Система управления абитуриентами «ApplicantManagementApp».
### Название приложения: ApplicantManagementApp
### Описание приложения:
**Это программное обеспечение, которое помогает учебным заведениям (вузам, колледжам) управлять процессом приема абитуриентов. Она автоматизирует и упрощает многие задачи, связанные с приемом, от подачи заявлений до зачисления студентов.**

# Функции, реализованные в программе:
1. **Подача и обработка заявлений** При запуске программы сразу виден список доступных тем. При нажатии на кнопку “Открыть первую тему” открывается материал по теме, которая находится вверху списка.
2. **Онлайн-подача заявлений** Абитуриенты могут подать заявления на поступление в вуз онлайн, заполняя электронную форму.
3. **Проверка документов** Система проверяет полноту и правильность предоставленных документов (паспорт, номер телефона и т.д)
4. **Управление статусом заявлений** Отслеживание статуса заявления (в обработке, одобрено, отклонено, зачислено).
5. **Регистрация на вступительные экзамены** Система позволяет абитуриентам зарегистрироваться на вступительные экзамены.
6. **Формирование рейтинговых списков** Создание списков абитуриентов по результатам вступительных испытаний, в соответствии с установленным рейтингом.
7. **Автоматическое зачисление** Автоматическое зачисление абитуриентов в соответствии с выбранной специальностью.

# Технологии, которые были использованы для разработки приложения:
- **C#** - объектно-ориентированный язык программирования.
- **Visual Studio Community 2022** - интегрированная среда разработки (IDE), которая обеспечивает удобное создание, отладку и развертывание приложений.
- **Windows Presentation Foundation** - система для построения клиентских приложений Windows с визуально привлекательными возможностями взаимодействия с пользователем, графическая подсистема в составе .NET Framework, использующая язык XAML.
- **Microsoft SQL Server** - система управления реляционными базами данных (РСУБД), разработанная корпорацией Microsoft.
- **Entity Framework** - это набор технологий в ADO.NET, которые поддерживают разработку программных приложений, ориентированных на данные.

# Описание базы данных:
#### Файл базы данных называется AMS.bacpac <br/>
Файл базы данных расположен локально в проекте по пути **https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/bin/Debug/AMS.bacpac** </br>
В базе данных находится 7 таблиц: _Users_, которая состоит из колонок _idUser_, _surnameUser_, _nameUser_, _patronimicUser_, _telephoneNum_, _passportNum_, _idRole_, _pass_, _login_: в таблице хранятся данные о всех пользователях; _Roles_, которая состоит из колонок _idRole_, _nameRole_:в этой таблице хранятся данные о ролях в системе; _Statements_, которая состоит из колонок _idStatement_, _idUser_, _idStatus_, _idSpeciality_: в таблице содержится информация о заявках, которые абитуриенты подали на специальности;  _Status_, которая состоит из колонок _idStatus_, _nameStatus_: в таблице содержится информация о статусах;  _EnrolledUsers_, которая состоит из колонок _idUser_, _idSpeciality_, _idRate_, _Rate_: в таблице содержится информация о зачисленных пользователях;  _Speciality_, которая состоит из колонок  _idSpeciality_, _nameSpeciality_: в таблице содержится информация о специальностях;  _StatementsExams_, которая состоит из колонок _idStatementExam_, _idUser_, _idSpeciality_: в таблице содержится информация о заявках на вступительные экзамены, которые абитуриенты подали на специальности.





# Скриншоты приложения:

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/Registration.png">
</br>Окно регистрации
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/Autorization.png">
</br>Окно авторизации
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/EnrolleeWindow.png">
</br>Окно пользователя
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/DoStatement.png">
</br>Подача заявки на специальность
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AddStatement.png">
</br>Подача заявки на вступительные экзамены
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/RemoveStatement.png">
</br>Удаление заявки на вступительные экзамены
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/Rating.png">
</br>Рейтинг абитуриентов
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AdminWindow.png">
</br>Окно администратора
</br> </br> </br>
</p>

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AddUsers.png">
</br>Добавление пользователей
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AddAdmin.png">
</br>Добавление администратора
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AddEditor.png">
</br>Добавление редактора
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AddEnrollee.png">
</br>Добавление абитуриента
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/ListEnrollees.png">
</br>Просмотр зарегистрированных абитуриентов, их номер телефона, паспорт
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/ExamStatements.png">
</br>Просмотр заявок на вступительные экзамены
</br> </br> </br>
</p> 


<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/UpdateStatus.png">
</br>Изменения статуса заявок абитуриентов
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/GradeExam.png">
</br>Оценка результатов вступительных экзаменов
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/AddSpeciality.png">
</br>Добавление новой специальности
</br> </br> </br>
</p> 

<p align="center">
  <img <img src="https://github.com/ArinaKutina/ApplicantManagementApp/blob/main/ApplicantManagementApp/Screenshots/EditorWindow.png">
</br>Окно редактора
</br> </br> </br>
</p> 
