REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @2017/8/6 15:35:35


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes
Imports System.Xml.Serialization

Namespace mysql

''' <summary>
''' ```SQL
''' Task executing errors log
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `task_errors`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `task_errors` (
'''   `uid` int(11) NOT NULL,
'''   `app` int(11) NOT NULL COMMENT 'The task app name',
'''   `task` int(11) NOT NULL COMMENT 'The task uid',
'''   `exception` longtext NOT NULL COMMENT 'The exception message',
'''   `type` varchar(45) NOT NULL COMMENT 'GetType.ToString',
'''   `stack-trace` varchar(45) NOT NULL,
'''   `solved` int(11) NOT NULL DEFAULT '0' COMMENT '这个bug是否已经解决了？ 默认是0未解决，1为已经解决了',
'''   PRIMARY KEY (`uid`,`app`),
'''   KEY `fk_task_errors_app1_idx` (`app`),
'''   CONSTRAINT `error_task` FOREIGN KEY (`app`) REFERENCES `task_pool` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
'''   CONSTRAINT `fk_task_errors_app1` FOREIGN KEY (`app`) REFERENCES `app` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Task executing errors log';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("task_errors", Database:="smrucc-cloud", SchemaSQL:="
CREATE TABLE `task_errors` (
  `uid` int(11) NOT NULL,
  `app` int(11) NOT NULL COMMENT 'The task app name',
  `task` int(11) NOT NULL COMMENT 'The task uid',
  `exception` longtext NOT NULL COMMENT 'The exception message',
  `type` varchar(45) NOT NULL COMMENT 'GetType.ToString',
  `stack-trace` varchar(45) NOT NULL,
  `solved` int(11) NOT NULL DEFAULT '0' COMMENT '这个bug是否已经解决了？ 默认是0未解决，1为已经解决了',
  PRIMARY KEY (`uid`,`app`),
  KEY `fk_task_errors_app1_idx` (`app`),
  CONSTRAINT `error_task` FOREIGN KEY (`app`) REFERENCES `task_pool` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_task_errors_app1` FOREIGN KEY (`app`) REFERENCES `app` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Task executing errors log';")>
Public Class task_errors: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("uid"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="uid"), XmlAttribute> Public Property uid As Long
''' <summary>
''' The task app name
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("app"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="app"), XmlAttribute> Public Property app As Long
''' <summary>
''' The task uid
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("task"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="task")> Public Property task As Long
''' <summary>
''' The exception message
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("exception"), NotNull, DataType(MySqlDbType.Text), Column(Name:="exception")> Public Property exception As String
''' <summary>
''' GetType.ToString
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("type"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="type")> Public Property type As String
    <DatabaseField("stack-trace"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="stack-trace")> Public Property stack_trace As String
''' <summary>
''' 这个bug是否已经解决了？ 默认是0未解决，1为已经解决了
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("solved"), NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="solved")> Public Property solved As Long
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `task_errors` (`uid`, `app`, `task`, `exception`, `type`, `stack-trace`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `task_errors` (`uid`, `app`, `task`, `exception`, `type`, `stack-trace`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `task_errors` WHERE `uid`='{0}' and `app`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `task_errors` SET `uid`='{0}', `app`='{1}', `task`='{2}', `exception`='{3}', `type`='{4}', `stack-trace`='{5}', `solved`='{6}' WHERE `uid`='{7}' and `app`='{8}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `task_errors` WHERE `uid`='{0}' and `app`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, uid, app)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `task_errors` (`uid`, `app`, `task`, `exception`, `type`, `stack-trace`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, uid, app, task, exception, type, stack_trace, solved)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{uid}', '{app}', '{task}', '{exception}', '{type}', '{stack_trace}', '{solved}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `task_errors` (`uid`, `app`, `task`, `exception`, `type`, `stack-trace`, `solved`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, uid, app, task, exception, type, stack_trace, solved)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `task_errors` SET `uid`='{0}', `app`='{1}', `task`='{2}', `exception`='{3}', `type`='{4}', `stack-trace`='{5}', `solved`='{6}' WHERE `uid`='{7}' and `app`='{8}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, uid, app, task, exception, type, stack_trace, solved, uid, app)
    End Function
#End Region
Public Function Clone() As task_errors
                  Return DirectCast(MyClass.MemberwiseClone, task_errors)
              End Function
End Class


End Namespace
