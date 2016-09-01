# DapperDemo
Dapper,C#,CSharp,Demo

主页（Homepage）

https://github.com/StackExchange/dapper-dot-net

参考Blog(Refer to Blog):

http://www.cnblogs.com/liuning8023/p/4363910.html
http://www.cnblogs.com/cyb331/category/547284.html
http://www.lanhusoft.com/Article/181.html
http://www.cnblogs.com/yankliu-vip/p/4182892.html

扩展Extension：
http://stackoverflow.com/questions/10030285/dapper-rainbow-vs-dapper-contrib

简介Summary
Dapper.NET是个开源的轻型ORM。它扩展了IDbConnection接口的功能，所以只要某类实现IDbConnection接口，那么该类对象就能调用到Dapper.NET中的IDbConnection扩展方法。
运行速度十分快，接近于IDataReader，因为它的映射工作原理是通过Emit反射IDataReader的序列队列，来快速地得到和产生对象。如下两表显示的数据（数据由官网提供）体现了它的性能优势。

Demo包括了如下主题：
1.Query泛型方法的使用
2.Query非泛型方法的使用
3.QueryMultiple()方法的使用
4.单条记录的增、改、删
5.批量增、改、删
6.ExecuteScalar()方法的使用
7.如何调用存储过程
