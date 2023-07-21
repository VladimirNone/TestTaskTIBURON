# Запуск
Для запуска необходимо выполнить команду в консоли
> `docker-compose up`

## Краткое описание
Программа самостоятельно создает базу данных, а также генерирует тестовые данные. Доступ к программе осуществляеется по адрессу `http://localhost:5000/`.

Get запрос
> http://localhost:5000/survey/getQuestion/1

Для тестового задания использовались сущности при возвращении данных, однако в рабочем проекте необходимо использовать DTO, которые наполнять с помощью AutoMapper.

Post запрос
> http://localhost:5000/survey/postAnswers 

Payload
```
{
    "InterviewId": 1,
    "QuestionId":1,
    "answersId":[1,2]
}
```
```
{
    "InterviewId": 1,
    "QuestionId":2,
    "answersId":[3]
}
```
После второго Post запроса метод вернет -1, т.к. это был финальный вопрос.

## ЯП и технологии
ASP.NET Core, C#, Postgres, Docker, EntityFramework Core
