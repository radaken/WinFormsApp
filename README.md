# WinFormsApp

Simple App with line-by-line :ru: comments.
If you start in C# and WinForms you can play with this project

![Demo](./demo.gif)

## What the idea of this app?
Maybe it's solution for traffic police. It worked with MSSQL db which has info about cars:

- brand
- model
- build year
- year of last tech
- name of owner
- fine amount

You can operate with this params and create new car

## What you can learn from it?
How to:
- [x] Work with own library (DLL)
- [x] Work with MSSQL
- [x] Proceeds data from one form to other (not delegate, all stuff syncs with table immediatly)
- [x] Work with WinForms
- [x] Insert data in sql without knowing a ID

## Sets and reqs:

1) You should install Microsoft SQL Server Developer (not MS SQL Express!!!)
2) Create local db, and do this command:
```SQL

CREATE TABLE [dbo].[carDB] (
    [Id]         INT           NOT NULL,
    [brand]      NVARCHAR (50) NULL,
    [model]      NVARCHAR (50) NULL,
    [year]       NVARCHAR (50) NULL,
    [lasttech]   NVARCHAR (50) NULL,
    [owner]      NVARCHAR (50) NULL,
    [fineamount] NVARCHAR (50) DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
Or just make `carDB` table and this columns. Dont forget to fill this with some junk data

## Knowing issues

> Cannot update combobox while when you creating new car

Something with databindings. You can easy fix this if you want
> New forms open in top left corner

Also you can fix this in form Designer
> No button for delete

You can write it by urself ;]
> While you sale car `Продать автомобиль` main form hiding this field `ФИО Владельца`
Security reason ;] You can copypaste 1 line and this thing will worked
