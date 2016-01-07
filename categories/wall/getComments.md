---
layout: default
title: Метод Wall.GetComments
permalink: wall/getComments/
comments: true
---
# Метод Wall.GetComments
Возвращает список комментариев к записи на стене пользователя.

## Синтаксис
```csharp
public ReadOnlyCollection<Comment> GetComments(
	long ownerId, 
	long postId, 
	out int totalCount, 
	CommentsSort sort, 
	bool needLikes, 
	int? count = null, 
	int? offset = null, 
	int previewLength
)
```

## Параметры
+ **ownerId** - Идентификатор пользователя, на чьей стене находится запись, к которой необходимо получить комментарии.
+ **postId** - Идентификатор записи на стене пользователя.
+ **totalCount** - Общее количество комментариев к записи.
+ **sort** - Порядок сортировки комментариев (по умолчанию хронологический).
+ **needLikes** - Признак нужно ли возвращать поле Likes в комментариях.
+ **count** - Количество комментариев, которое необходимо получить (но не более 100).
+ **offset** - Смещение, необходимое для выборки определенного подмножества комментариев.
+ **previewLength** - Количество символов, по которому нужно обрезать комментарии. Если указано 0, то комментарии не образаются.

## Результат
Список комментариев к записи на стене пользователя.

## Исключения

## Пример
```csharp
// TODO:
```