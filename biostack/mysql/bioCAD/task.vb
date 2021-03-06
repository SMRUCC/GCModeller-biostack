REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/18/2018 5:37:20 PM


Imports System.Data.Linq.Mapping
Imports System.Xml.Serialization
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports MySqlScript = Oracle.LinuxCompatibility.MySQL.Scripting.Extensions

Namespace MySql.bioCAD

''' <summary>
''' ```SQL
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `task`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `task` (
'''   `id` int(11) NOT NULL AUTO_INCREMENT,
'''   `sha1` varchar(32) NOT NULL,
'''   `user_id` int(11) NOT NULL,
'''   `project_id` int(11) NOT NULL,
'''   `app_id` int(11) NOT NULL COMMENT '这个任务所使用到的分析程序的编号，后台任务系统会需要这个编号来调用相应的数据分析程序',
'''   `title` varchar(128) NOT NULL,
'''   `create_time` datetime NOT NULL,
'''   `finish_time` datetime DEFAULT NULL,
'''   `status` int(11) NOT NULL COMMENT '任务状态或者任务的执行结果\n\n0: 任务等待被执行\n1: 任务执行中\n200: 执行成功\n500: 出错',
'''   `note` tinytext,
'''   `parameters` longtext NOT NULL COMMENT '参数json',
'''   PRIMARY KEY (`id`,`sha1`),
'''   UNIQUE KEY `id_UNIQUE` (`id`),
'''   UNIQUE KEY `sha1_UNIQUE` (`sha1`)
''' ) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("task", Database:="biocad", SchemaSQL:="
CREATE TABLE `task` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sha1` varchar(32) NOT NULL,
  `user_id` int(11) NOT NULL,
  `project_id` int(11) NOT NULL,
  `app_id` int(11) NOT NULL COMMENT '这个任务所使用到的分析程序的编号，后台任务系统会需要这个编号来调用相应的数据分析程序',
  `title` varchar(128) NOT NULL,
  `create_time` datetime NOT NULL,
  `finish_time` datetime DEFAULT NULL,
  `status` int(11) NOT NULL COMMENT '任务状态或者任务的执行结果\n\n0: 任务等待被执行\n1: 任务执行中\n200: 执行成功\n500: 出错',
  `note` tinytext,
  `parameters` longtext NOT NULL COMMENT '参数json',
  PRIMARY KEY (`id`,`sha1`),
  UNIQUE KEY `id_UNIQUE` (`id`),
  UNIQUE KEY `sha1_UNIQUE` (`sha1`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;")>
Public Class task: Inherits Oracle.LinuxCompatibility.MySQL.MySQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("id"), PrimaryKey, AutoIncrement, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="id"), XmlAttribute> Public Property id As Long
    <DatabaseField("sha1"), PrimaryKey, NotNull, DataType(MySqlDbType.VarChar, "32"), Column(Name:="sha1"), XmlAttribute> Public Property sha1 As String
    <DatabaseField("user_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="user_id")> Public Property user_id As Long
    <DatabaseField("project_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="project_id")> Public Property project_id As Long
''' <summary>
''' 这个任务所使用到的分析程序的编号，后台任务系统会需要这个编号来调用相应的数据分析程序
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("app_id"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app_id")> Public Property app_id As Long
    <DatabaseField("title"), NotNull, DataType(MySqlDbType.VarChar, "128"), Column(Name:="title")> Public Property title As String
    <DatabaseField("create_time"), NotNull, DataType(MySqlDbType.DateTime), Column(Name:="create_time")> Public Property create_time As Date
    <DatabaseField("finish_time"), DataType(MySqlDbType.DateTime), Column(Name:="finish_time")> Public Property finish_time As Date
''' <summary>
''' 任务状态或者任务的执行结果\n\n0: 任务等待被执行\n1: 任务执行中\n200: 执行成功\n500: 出错
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("status"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="status")> Public Property status As Long
    <DatabaseField("note"), DataType(MySqlDbType.Text), Column(Name:="note")> Public Property note As String
''' <summary>
''' 参数json
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("parameters"), NotNull, DataType(MySqlDbType.Text), Column(Name:="parameters")> Public Property parameters As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Friend Shared ReadOnly INSERT_SQL$ = 
        <SQL>INSERT INTO `task` (`sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>

    Friend Shared ReadOnly INSERT_AI_SQL$ = 
        <SQL>INSERT INTO `task` (`id`, `sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');</SQL>

    Friend Shared ReadOnly REPLACE_SQL$ = 
        <SQL>REPLACE INTO `task` (`sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');</SQL>

    Friend Shared ReadOnly REPLACE_AI_SQL$ = 
        <SQL>REPLACE INTO `task` (`id`, `sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');</SQL>

    Friend Shared ReadOnly DELETE_SQL$ =
        <SQL>DELETE FROM `task` WHERE `id`='{0}' and `sha1`='{1}';</SQL>

    Friend Shared ReadOnly UPDATE_SQL$ = 
        <SQL>UPDATE `task` SET `id`='{0}', `sha1`='{1}', `user_id`='{2}', `project_id`='{3}', `app_id`='{4}', `title`='{5}', `create_time`='{6}', `finish_time`='{7}', `status`='{8}', `note`='{9}', `parameters`='{10}' WHERE `id`='{11}' and `sha1`='{12}';</SQL>

#End Region

''' <summary>
''' ```SQL
''' DELETE FROM `task` WHERE `id`='{0}' and `sha1`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, id, sha1)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `task` (`id`, `sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters)
    End Function

''' <summary>
''' ```SQL
''' INSERT INTO `task` (`id`, `sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(INSERT_AI_SQL, id, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters)
        Else
        Return String.Format(INSERT_SQL, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters)
        End If
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue(AI As Boolean) As String
        If AI Then
            Return $"('{id}', '{sha1}', '{user_id}', '{project_id}', '{app_id}', '{title}', '{create_time}', '{finish_time}', '{status}', '{note}', '{parameters}')"
        Else
            Return $"('{sha1}', '{user_id}', '{project_id}', '{app_id}', '{title}', '{create_time}', '{finish_time}', '{status}', '{note}', '{parameters}')"
        End If
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `task` (`id`, `sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters)
    End Function

''' <summary>
''' ```SQL
''' REPLACE INTO `task` (`id`, `sha1`, `user_id`, `project_id`, `app_id`, `title`, `create_time`, `finish_time`, `status`, `note`, `parameters`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL(AI As Boolean) As String
        If AI Then
        Return String.Format(REPLACE_AI_SQL, id, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters)
        Else
        Return String.Format(REPLACE_SQL, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters)
        End If
    End Function

''' <summary>
''' ```SQL
''' UPDATE `task` SET `id`='{0}', `sha1`='{1}', `user_id`='{2}', `project_id`='{3}', `app_id`='{4}', `title`='{5}', `create_time`='{6}', `finish_time`='{7}', `status`='{8}', `note`='{9}', `parameters`='{10}' WHERE `id`='{11}' and `sha1`='{12}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, id, sha1, user_id, project_id, app_id, title, MySqlScript.ToMySqlDateTimeString(create_time), MySqlScript.ToMySqlDateTimeString(finish_time), status, note, parameters, id, sha1)
    End Function
#End Region

''' <summary>
                     ''' Memberwise clone of current table Object.
                     ''' </summary>
                     Public Function Clone() As task
                         Return DirectCast(MyClass.MemberwiseClone, task)
                     End Function
End Class


End Namespace
