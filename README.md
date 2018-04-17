# qianlong-email-marketing-assistant

该邮件群发系统使用C#+Web协调运行机制，本地邮件服务将作为临时测试使用，正式运行请添加正式的邮件服务。
![screenshot](https://github.com/bywei/qianlong-email-marketing-assistant/raw/master/Screenshots/banner/3.jpg)

![screenshot](https://github.com/bywei/qianlong-email-marketing-assistant/raw/master/Screenshots/login.png)
![screenshot](https://github.com/bywei/qianlong-email-marketing-assistant/raw/master/Screenshots/reg.png)
![screenshot](https://github.com/bywei/qianlong-email-marketing-assistant/raw/master/Screenshots/main.png)

# 系统优势
![screenshot](https://github.com/bywei/qianlong-email-marketing-assistant/raw/master/Screenshots/banner/2.jpg)

# 版本说明
```
V2.0.0升级记录
1.邮件时间配置
2.登录大小写问题
3.注册中文问题
4.发件配置：购买企业版发件邮箱和链接
5.登录界面广告
6.邮件内容广告
7.批量生成发邮箱的小号
8.测试一封大于10使用list列表
9.邮件发送机制：
 构建线程池
 (1)一封邮件发送失败后，临时保存
  --(2)连续发送失败3封后更换发件人
  --(4)连续发送(用户自定义发送N封)封后睡眠一会儿
  --(5)通过主线程来控制发送的排序(发送到什么地方了)
  --(6)生成子线程来控制连续发送几封邮件(控制(4))
  --(7)如果发件人循环完毕，就（更换ip），再重新循环发送
 (8)运行完毕之后，进行失败项的第二次发送
  --(9)用户自定义发送N封邮件后换发件人
 (10)内容中间添加白色字符和宏变量
  --(11)如果用户没有自定义邮件发送邮件数量=>采用平均分配 发件人
 (12)记录已经发送的位置
10.把广告放入到数据库中，一次性读取

V2.3.0升级记录
1.增加了在线邮件营销效果跟踪，已经实现了在线申请软件帐号，在线管理个人资料信息，邮件内部链接统计分析等功能。
[Web管理项目](https://github.com/bywei/qianlong-email-marketing-assistant)
2.修改用户登录记录，每次只能登录一个用户。防止帐号多个地方登录。

V2.3.1升级记录
1.增加了来源邮箱的统计分析，结合在线邮件营销跟踪系统

V2.3.2升级记录
1.当软件登录帐号被锁定，设置五分钟后可自动登录
2.设置测试一封只能测试前二十个发件人
3.邮件标题使用 ‘|’分割，可以添加多个标题，发送时随机选择标题

V2.3.2升级记录
--失败的右键重新发送

Qianlongsoft_email_v2.3.2 升级日志
1.增加导入收件人完成后的提示信息
2.提升导入收件人速度
3.修改切换界面显示花屏问题
4.增加删除发发送的时候箱
5.隐藏smtp地址
6.卸载不干净
7.兼容w7 jet

Qianlongsoft_email_v2.3.4 
1.在收件人管理里面添加删除发送成功的收件人
2.增加钱龙smtp服务器
3.增加邮件编辑日期变量
4.增加html在线编辑器
5.修改登录界面特效

Qianlongsoft_email_v2.5.0
1.增加企业邮箱服务器
  smtp1.qianlongsoft.com
  smtp2.qianlongsoft.com
  smtp3.qianlongsoft.com
  smtp4.qianlongsoft.com
  smtp5.qianlongsoft.com
  smtp6.qianlongsoft.com
2.修改软件风格样式，增加用户体验
3.修改v2.3.4遗留的发送时间问题
4.去掉试用用户的邮件广告

Qianlongsoft_email_v2.5.1
1.修复个人信息界面
  增加了邮件群发技巧教程
  增加了邮件统计链接
  修复了刷新信息产生的多个icon
2.修复编辑邮件时插入代码问题
3.修复发件统计代码，使其自动化识别链接地址
```
![screenshot](https://github.com/bywei/qianlong-email-marketing-assistant/raw/master/Screenshots/banner/1.jpg)
## 关于作者

bywei = 程序员百味

个人博客 = "http://www.bywei.cn"



## 用户协议
* 禁止用户在使用中触犯中国法律范围内的任何法律条文。
* 不通过出售任何以此项目为基础开发的产品，仅用作自身学习研究使用。
* 任何个人，公司和组织不得以任何形式和目的侵犯百味博客的版权和著作权。
* 在未经官方书面允许的情况下，任何个人、公司和组织不能单方面发布和出售以此项目为基础开发的任何互联网软件或者产品，否则将视为侵权行为，将依照中华人民共和国法律追究其法律责任。




