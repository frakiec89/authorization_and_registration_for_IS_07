
скрины 
https://disk.yandex.ru/d/JQZAcFMh13XNJg

инструкция 

1. Установить Зависимости  (управление пакетами nuget) Screenshot_1
 
(версия в  зависимости от версии  .net пректа )

"Microsoft.EntityFrameworkCore" Version="7.0.16" />
"Microsoft.EntityFrameworkCore.Sqlite" Version="7.0.16" />
<"Microsoft.EntityFrameworkCore.Tools" Version="7.0.16">

2. создать  файлы  контекста  (папка  bd)
Screenshot_2
(папку  создать)

3.  провести  миграции  (Screenshot_3)

команды для миграции  -- (консль  диспетчра  пакетов)
Add-Migration -Name ВашеnameMigration
Update-Database

4.  назначить бд  как  выходной  файл  проекта  
сделать bild 
Screenshot_5.png
Screenshot_6.png
убедиться что  бд  есть  
Screenshot_7.png

5 открыть  бд  через DB  Brouser 
Screenshot_8.png
