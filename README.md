
First of all, I'm sorry about clsBusiness ,it has wrong syntax 
After you downloded zip file , you must use BackupFile in your Sql server , you can use this code to restore it
RESTORE DATABASE [RetainCarsProject]
FROM DISK = 'C:\MyDatabase.bak'==> put here the path of Backup after move it to C drive
-------------

After that, before you run the programe you must put your Sql server info in ConnectionString , Look to the picture
![Please check this Picture](https://github.com/user-attachments/assets/dd144ff4-f529-43c2-a317-fc6ab4ca2845)
---
Now You can Run it 
-
