# APEX-EACBypass  
# 用法：  
 编译出来重命名为"EasyAntiCheat_launcher.exe"替换到游戏目录下，用橘子平台启动游戏  
# 关于心跳
写个空的dll命名为"EasyAntiCheat_x64.dll"替换到游戏目录下用你自己的方式加载到游戏里  
# RWE Bypass
EAC用ObRegisterCallbacks注册了4-5个回调，直接恢复游戏秒结束，所以恢复不可行(而且起了几个线程一直在检测和恢复)，头部ret也不行。它做了什么：降权  
举个例子：比如你要打开"r5apex.exe"这个进程，"PROCESS_ALL_ACCESS"，肯定被降权，这个时候你先别管他去掉了哪几个权限，传到你的驱动里面，遍历句柄表找到这个句柄把"GrantedAccess"改成"0x1FFFFF".  
现在EAC还没有和BE一样定时清空句柄表，先这么用着吧，如果他开始定时清空句柄表了，那“完全的R3读写”就要另辟巧径了.  


