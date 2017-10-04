var WebKitDetect = {}; WebKitDetect.isWebKit = function isWebKit() { return RegExp(" AppleWebKit/").test(navigator.userAgent) }; WebKitDetect.version = function version() { var h = RegExp("( AppleWebKit/)([^ ]+)").exec(navigator.userAgent); if(!h || h.length < 3) { return null } var g = h[2]; var j = g.indexOf("+") != -1; var i = RegExp("[^\\.0-9]").exec(g); if(i) { g = g.slice(0, i.index) } var f = g.split("."); f.isNightlyBuild = j; return f }; WebKitDetect.versionIsAtLeast = function versionIsAtLeast(k) { function n(b) { var a = parseInt(b); return isNaN(a) ? 0 : a } if(k === undefined) { k = "" } var j = k.split("."); var h = WebKitDetect.version(); if(!h) { return false } if(h.isNightlyBuild) { return true } for(var l = 0; l < j.length; l++) { var m = n(h[l]); var i = n(j[l]); if(m > i) { return true } if(m < i) { return false } } return true }; WebKitDetect.isMobile = function isMobile() { return WebKitDetect.isWebKit() && RegExp(" Mobile/").test(navigator.userAgent) }; WebKitDetect.mobileDevice = function mobileDevice() { if(!WebKitDetect.isMobile()) { return null } var b = RegExp("(Mozilla/5.0 \\()([^;]+)").exec(navigator.userAgent); if(!b || b.length < 3) { return null } return b[2] }; WebKitDetect._mobileVersion = function _mobileVersion(c) { var d = RegExp("([0-9]+)([A-Z]+)([0-9]+)").exec(c); if(!d || d.length != 4) { return null } return [d[1], d[2], d[3]] }; WebKitDetect.mobileVersion = function mobileVersion() { var d = RegExp("( Mobile/)([^ ]+)").exec(navigator.userAgent); if(!d || d.length < 3) { return null } var c = d[2]; return WebKitDetect._mobileVersion(c) }; WebKitDetect.mobileVersionIsAtLeast = function mobileVersionIsAtLeast(n) { function t(b) { var a = parseInt(b); return isNaN(a) ? 0 : a } if(n === undefined) { n = "" } var l = WebKitDetect._mobileVersion(n); var m = WebKitDetect.mobileVersion(); if(!m) { return false } var p = t(m[0]); var s = t(l[0]); if(p > s) { return true } if(p < s) { return false } var o = m[1]; var r = l[1]; if(o > r) { return true } if(o < r) { return false } var k = t(m[2]); var q = t(l[2]); if(k > q) { return true } if(k < q) { return false } return true }; function getCookie(h) { var e = "" + document.cookie; var g = e.indexOf(h); if(e == "" || g == -1) { return "" } var f = e.indexOf(";", g); if(f == -1) { f = e.length } return unescape(e.substring(g + h.length + 1, f)) } function setCookieForXDays(h, f, g) { var e = new Date(); e.setDate(e.getDate() + g); document.cookie = h + "=" + escape(f) + ";path=/;expires=" + e.toGMTString() } var slCookieName = "SLInstallPostponed7"; var slTestCookieName = "TestCookiesEnabled"; var noCookies = 0; function PageGate() {$(document).ready(function() { $("#pagegate-shim").fancybox({ overlayShow: true, overlayOpacity: 0.5, frameWidth: 467, frameHeight: 267, hideOnContentClick: false }); });   var i = WebKitDetect.isWebKit(); var g = WebKitDetect.isMobile(); var h = navigator.userAgent.toLowerCase().indexOf("chrome") > -1; if((!i || (i && !g)) && !h) { if(!Silverlight.isInstalled("3.0.40624.0")) { BrowserDetect.init(); if(BrowserDetect.OS == "Windows" && BrowserDetect.browser == "Explorer" && navigator.userAgent.indexOf("Win64") >= 0) { return } else { var f = getCookie(slCookieName); if(f != "ok") { if(f != "reset") { setCookieForXDays(slTestCookieName, "ok", 1); var j = document.createElement("iframe"); j.style.visibility = "hidden";$(j).css("height", 0); document.body.appendChild(j); j.src = "/pagegate/checkcookie.html"; setTimeout(PageGatePopup, 2000) } else { PageGatePopup() } } } } } } function PageGatePopup() { if(noCookies) { return } if(typeof (PrePageGate) != "undefined") { PrePageGate() } $("#fancy_inner").css("width", 490); $("#pagegate-shim").click(); if(!Silverlight.available && BrowserDetect.browser == "Explorer") { TimeoutDelegate = function() { if(Silverlight.isInstalled("0.90.0")) { window.location.reload(false) } else { setTimeout(TimeoutDelegate, 3000) } }; setTimeout(TimeoutDelegate, 3000) } if(typeof (PostPageGate) != "undefined") { PostPageGate() } setCookieForXDays(slCookieName, "ok", 7) } function CookiesAreDisabled() { noCookies = 1 } function TestCookiesEnabled() { var b = getCookie(slTestCookieName); if(b != "ok") { window.parent.CookiesAreDisabled() } } var BrowserDetect = { init: function() { this.browser = this.searchString(this.dataBrowser) || "An unknown browser"; this.version = this.searchVersion(navigator.userAgent) || this.searchVersion(navigator.appVersion) || "an unknown version"; this.OS = this.searchString(this.dataOS) || "an unknown OS" }, searchString: function(g) { for(var f = 0; f < g.length; f++) { var e = g[f].string; var h = g[f].prop; this.versionSearchString = g[f].versionSearch || g[f].identity; if(e) { if(e.indexOf(g[f].subString) != -1) { return g[f].identity } } else { if(h) { return g[f].identity } } } }, searchVersion: function(c) { var d = c.indexOf(this.versionSearchString); if(d == -1) { return } return parseFloat(c.substring(d + this.versionSearchString.length + 1)) }, dataBrowser: [{ string: navigator.userAgent, subString: "OmniWeb", versionSearch: "OmniWeb/", identity: "OmniWeb" }, { string: navigator.vendor, subString: "Apple", identity: "Safari" }, { prop: window.opera, identity: "Opera" }, { string: navigator.vendor, subString: "iCab", identity: "iCab" }, { string: navigator.vendor, subString: "KDE", identity: "Konqueror" }, { string: navigator.userAgent, subString: "Firefox", identity: "Firefox" }, { string: navigator.vendor, subString: "Camino", identity: "Camino" }, { string: navigator.userAgent, subString: "Netscape", identity: "Netscape" }, { string: navigator.userAgent, subString: "MSIE", identity: "Explorer", versionSearch: "MSIE" }, { string: navigator.userAgent, subString: "Gecko", identity: "Mozilla", versionSearch: "rv" }, { string: navigator.userAgent, subString: "Mozilla", identity: "Netscape", versionSearch: "Mozilla"}], dataOS: [{ string: navigator.platform, subString: "Win", identity: "Windows" }, { string: navigator.platform, subString: "Mac", identity: "Mac" }, { string: navigator.platform, subString: "Linux", identity: "Linux"}] }; if(!window.Silverlight) { window.Silverlight = {} } Silverlight._silverlightCount = 0; Silverlight.fwlinkRoot = "http://go2.microsoft.com/fwlink/?LinkID="; Silverlight.onGetSilverlight = null; Silverlight.onSilverlightInstalled = function() { window.location.reload(false) }; Silverlight.isInstalled = function(k) { var m = false; var a = null; try { var g = null; try { g = new ActiveXObject("AgControl.AgControl"); if(k == null) { m = true } else { if(g.IsVersionSupported(k)) { m = true } } g = null } catch(j) { var h = navigator.plugins["Silverlight Plug-In"]; if(h) { if(k === null) { m = true } else { var b = h.description; if(b === "1.0.30226.2") { b = "2.0.30226.2" } var c = b.split("."); while(c.length > 3) { c.pop() } while(c.length < 4) { c.push(0) } var d = k.split("."); while(d.length > 4) { d.pop() } var l; var f; var i = 0; do { l = parseInt(d[i]); f = parseInt(c[i]); i++ } while(i < d.length && l === f); if(l <= f && !isNaN(l)) { m = true } } } } } catch(j) { m = false } if(a) { document.body.removeChild(a) } return m }; Silverlight.WaitForInstallCompletion = function() { if(!Silverlight.isBrowserRestartRequired && Silverlight.onSilverlightInstalled) { try { navigator.plugins.refresh() } catch(a) { } if(Silverlight.isInstalled(null)) { Silverlight.onSilverlightInstalled() } else { setTimeout(Silverlight.WaitForInstallCompletion, 3000) } } }; Silverlight.__startup = function() { Silverlight.isBrowserRestartRequired = Silverlight.isInstalled(null); if(!Silverlight.isBrowserRestartRequired) { Silverlight.WaitForInstallCompletion() } if(window.removeEventListener) { window.removeEventListener("load", Silverlight.__startup, false) } else { window.detachEvent("onload", Silverlight.__startup) } }; if(window.addEventListener) { window.addEventListener("load", Silverlight.__startup, false) } else { window.attachEvent("onload", Silverlight.__startup) } Silverlight.createObject = function(a, j, c, h, l, f, g) { var m = new Object(); var d = h; var k = l; m.version = d.version; d.source = a; m.alt = d.alt; if(f) { d.initParams = f } if(d.isWindowless && !d.windowless) { d.windowless = d.isWindowless } if(d.framerate && !d.maxFramerate) { d.maxFramerate = d.framerate } if(c && !d.id) { d.id = c } delete d.ignoreBrowserVer; delete d.inplaceInstallPrompt; delete d.version; delete d.isWindowless; delete d.framerate; delete d.data; delete d.src; delete d.alt; if(Silverlight.isInstalled(m.version)) { for(var b in k) { if(k[b]) { if(b == "onLoad" && typeof k[b] == "function" && k[b].length != 1) { var i = k[b]; k[b] = function(n) { return i(document.getElementById(c), g, n) } } var e = Silverlight.__getHandlerName(k[b]); if(e != null) { d[b] = e; k[b] = null } else { throw "typeof events." + b + " must be 'function' or 'string'" } } } slPluginHTML = Silverlight.buildHTML(d) } else { slPluginHTML = Silverlight.buildPromptHTML(m) } if(j) { j.innerHTML = slPluginHTML } else { return slPluginHTML } }; Silverlight.buildHTML = function(c) { var b = []; b.push('<object type="application/x-silverlight" data="data:application/x-silverlight,"'); if(c.id != null) { b.push(' id="' + c.id + '"') } if(c.width != null) { b.push(' width="' + c.width + '"') } if(c.height != null) { b.push(' height="' + c.height + '"') } b.push(" >"); delete c.id; delete c.width; delete c.height; for(var a in c) { if(c[a]) { b.push('<param name="' + Silverlight.HtmlAttributeEncode(a) + '" value="' + Silverlight.HtmlAttributeEncode(c[a]) + '" />') } } b.push("</object>"); return b.join("") }; Silverlight.createObjectEx = function(c) { var b = c; var a = Silverlight.createObject(b.source, b.parentElement, b.id, b.properties, b.events, b.initParams, b.context); if(b.parentElement == null) { return a } }; Silverlight.buildPromptHTML = function(b) { var d = ""; var c = Silverlight.fwlinkRoot; var a = b.version; if(b.alt) { d = b.alt } else { if(!a) { a = "" } d = "<a href='javascript:Silverlight.getSilverlight(\"{1}\");' style='text-decoration: none;'><img src='{2}' alt='Get Microsoft Silverlight' style='border-style: none'/></a>"; d = d.replace("{1}", a); d = d.replace("{2}", c + "108181") } return d }; Silverlight.getSilverlight = function(c) { if(Silverlight.onGetSilverlight) { Silverlight.onGetSilverlight() } var a = ""; var e = String(c).split("."); if(e.length > 1) { var d = parseInt(e[0]); if(isNaN(d) || d < 2) { a = "1.0" } else { a = e[0] + "." + e[1] } } var b = ""; if(a.match(/^\d+\056\d+$/)) { b = "&v=" + a } Silverlight.followFWLink("114576" + b) }; Silverlight.followFWLink = function(a) { top.location = Silverlight.fwlinkRoot + String(a) }; Silverlight.HtmlAttributeEncode = function(b) { var e; var d = ""; if(b == null) { return null } for(var a = 0; a < b.length; a++) { e = b.charCodeAt(a); if(((e > 96) && (e < 123)) || ((e > 64) && (e < 91)) || ((e > 43) && (e < 58) && (e != 47)) || (e == 95)) { d = d + String.fromCharCode(e) } else { d = d + "&#" + e + ";" } } return d }; Silverlight.default_error_handler = function(b, a) { var c; var e = a.ErrorType; c = a.ErrorCode; var d = "\nSilverlight error message     \n"; d += "ErrorCode: " + c + "\n"; d += "ErrorType: " + e + "       \n"; d += "Message: " + a.ErrorMessage + "     \n"; if(e == "ParserError") { d += "XamlFile: " + a.xamlFile + "     \n"; d += "Line: " + a.lineNumber + "     \n"; d += "Position: " + a.charPosition + "     \n" } else { if(e == "RuntimeError") { if(a.lineNumber != 0) { d += "Line: " + a.lineNumber + "     \n"; d += "Position: " + a.charPosition + "     \n" } d += "MethodName: " + a.methodName + "     \n" } } alert(d) }; Silverlight.__cleanup = function() { for(var a = Silverlight._silverlightCount - 1; a >= 0; a--) { window["__slEvent" + a] = null } Silverlight._silverlightCount = 0; if(window.removeEventListener) { window.removeEventListener("unload", Silverlight.__cleanup, false) } else { window.detachEvent("onunload", Silverlight.__cleanup) } }; Silverlight.__getHandlerName = function(b) { var a = ""; if(typeof b == "string") { a = b } else { if(typeof b == "function") { if(Silverlight._silverlightCount == 0) { if(window.addEventListener) { window.addEventListener("onunload", Silverlight.__cleanup, false) } else { window.attachEvent("onunload", Silverlight.__cleanup) } } var c = Silverlight._silverlightCount++; a = "__slEvent" + c; window[a] = b } else { a = null } } return a };

//silverlight.net

if(!window.Silverlight)
{window.Silverlight={};}
Silverlight._silverlightCount=0;Silverlight.fwlinkRoot='http://go2.microsoft.com/fwlink/?LinkID=';Silverlight.onGetSilverlight=null;Silverlight.onSilverlightInstalled=function(){window.location.reload(false);};Silverlight.isInstalled=function(version)
{var isVersionSupported=false;var container=null;try
{var control=null;try
{control=new ActiveXObject('AgControl.AgControl');if(version==null)
{isVersionSupported=true;}
else if(control.IsVersionSupported(version))
{isVersionSupported=true;}
control=null;}
catch(e)
{var plugin=navigator.plugins["Silverlight Plug-In"];if(plugin)
{if(version===null)
{isVersionSupported=true;}
else
{var actualVer=plugin.description;if(actualVer==="1.0.30226.2")
actualVer="2.0.30226.2";var actualVerArray=actualVer.split(".");while(actualVerArray.length>3)
{actualVerArray.pop();}
while(actualVerArray.length<4)
{actualVerArray.push(0);}
var reqVerArray=version.split(".");while(reqVerArray.length>4)
{reqVerArray.pop();}
var requiredVersionPart;var actualVersionPart
var index=0;do
{requiredVersionPart=parseInt(reqVerArray[index]);actualVersionPart=parseInt(actualVerArray[index]);index++;}
while(index<reqVerArray.length&&requiredVersionPart===actualVersionPart);if(requiredVersionPart<=actualVersionPart&&!isNaN(requiredVersionPart))
{isVersionSupported=true;}}}}}
catch(e)
{isVersionSupported=false;}
if(container)
{document.body.removeChild(container);}
return isVersionSupported;}
Silverlight.WaitForInstallCompletion=function()
{if(!Silverlight.isBrowserRestartRequired&&Silverlight.onSilverlightInstalled)
{try
{navigator.plugins.refresh();}
catch(e)
{}
if(Silverlight.isInstalled(null))
{Silverlight.onSilverlightInstalled();}
else
{setTimeout(Silverlight.WaitForInstallCompletion,3000);}}}
Silverlight.__startup=function()
{Silverlight.isBrowserRestartRequired=Silverlight.isInstalled(null);if(!Silverlight.isBrowserRestartRequired)
{Silverlight.WaitForInstallCompletion();}
if(window.removeEventListener){window.removeEventListener('load',Silverlight.__startup,false);}
else{window.detachEvent('onload',Silverlight.__startup);}}
if(window.addEventListener)
{window.addEventListener('load',Silverlight.__startup,false);}
else
{window.attachEvent('onload',Silverlight.__startup);}
Silverlight.createObject=function(source,parentElement,id,properties,events,initParams,userContext)
{var slPluginHelper=new Object();var slProperties=properties;var slEvents=events;slPluginHelper.version=slProperties.version;slProperties.source=source;slPluginHelper.alt=slProperties.alt;if(initParams)
slProperties.initParams=initParams;if(slProperties.isWindowless&&!slProperties.windowless)
slProperties.windowless=slProperties.isWindowless;if(slProperties.framerate&&!slProperties.maxFramerate)
slProperties.maxFramerate=slProperties.framerate;if(id&&!slProperties.id)
slProperties.id=id;delete slProperties.ignoreBrowserVer;delete slProperties.inplaceInstallPrompt;delete slProperties.version;delete slProperties.isWindowless;delete slProperties.framerate;delete slProperties.data;delete slProperties.src;delete slProperties.alt;if(Silverlight.isInstalled(slPluginHelper.version))
{for(var name in slEvents)
{if(slEvents[name])
{if(name=="onLoad"&&typeof slEvents[name]=="function"&&slEvents[name].length!=1)
{var onLoadHandler=slEvents[name];slEvents[name]=function(sender){return onLoadHandler(document.getElementById(id),userContext,sender)};}
var handlerName=Silverlight.__getHandlerName(slEvents[name]);if(handlerName!=null)
{slProperties[name]=handlerName;slEvents[name]=null;}
else
{throw"typeof events."+name+" must be 'function' or 'string'";}}}
slPluginHTML=Silverlight.buildHTML(slProperties);}
else
{slPluginHTML=Silverlight.buildPromptHTML(slPluginHelper);}
if(parentElement)
{parentElement.innerHTML=slPluginHTML;}
else
{return slPluginHTML;}}
Silverlight.buildHTML=function(slProperties)
{var htmlBuilder=[];htmlBuilder.push('<object type=\"application/x-silverlight\" data="data:application/x-silverlight,"');if(slProperties.id!=null)
{htmlBuilder.push(' id="'+slProperties.id+'"');}
if(slProperties.width!=null)
{htmlBuilder.push(' width="'+slProperties.width+'"');}
if(slProperties.height!=null)
{htmlBuilder.push(' height="'+slProperties.height+'"');}
htmlBuilder.push(' >');delete slProperties.id;delete slProperties.width;delete slProperties.height;for(var name in slProperties)
{if(slProperties[name])
{htmlBuilder.push('<param name="'+Silverlight.HtmlAttributeEncode(name)+'" value="'+Silverlight.HtmlAttributeEncode(slProperties[name])+'" />');}}
htmlBuilder.push('<\/object>');return htmlBuilder.join('');}
Silverlight.createObjectEx=function(params)
{var parameters=params;var html=Silverlight.createObject(parameters.source,parameters.parentElement,parameters.id,parameters.properties,parameters.events,parameters.initParams,parameters.context);if(parameters.parentElement==null)
{return html;}}
Silverlight.buildPromptHTML=function(slPluginHelper)
{var slPluginHTML="";var urlRoot=Silverlight.fwlinkRoot;var shortVer=slPluginHelper.version;if(slPluginHelper.alt)
{slPluginHTML=slPluginHelper.alt;}
else
{if(!shortVer)
{shortVer="";}
slPluginHTML="<a href='javascript:Silverlight.getSilverlight(\"{1}\");' style='text-decoration: none;'><img src='{2}' alt='Get Microsoft Silverlight' style='border-style: none'/></a>";slPluginHTML=slPluginHTML.replace('{1}',shortVer);slPluginHTML=slPluginHTML.replace('{2}',urlRoot+'108181');}
return slPluginHTML;}
Silverlight.getSilverlight=function(version)
{if(Silverlight.onGetSilverlight)
{Silverlight.onGetSilverlight();}
var shortVer="";var reqVerArray=String(version).split(".");if(reqVerArray.length>1)
{var majorNum=parseInt(reqVerArray[0]);if(isNaN(majorNum)||majorNum<2)
{shortVer="1.0";}
else
{shortVer=reqVerArray[0]+'.'+reqVerArray[1];}}
var verArg="";if(shortVer.match(/^\d+\056\d+$/))
{verArg="&v="+shortVer;}
Silverlight.followFWLink("114576"+verArg);}
Silverlight.followFWLink=function(linkid)
{top.location=Silverlight.fwlinkRoot+String(linkid);}
Silverlight.HtmlAttributeEncode=function(strInput)
{var c;var retVal='';if(strInput==null)
{return null;}
for(var cnt=0;cnt<strInput.length;cnt++)
{c=strInput.charCodeAt(cnt);if(((c>96)&&(c<123))||((c>64)&&(c<91))||((c>43)&&(c<58)&&(c!=47))||(c==95))
{retVal=retVal+String.fromCharCode(c);}
else
{retVal=retVal+'&#'+c+';';}}
return retVal;}
Silverlight.default_error_handler=function(sender,args)
{var iErrorCode;var errorType=args.ErrorType;iErrorCode=args.ErrorCode;var errMsg="\nSilverlight error message     \n";errMsg+="ErrorCode: "+iErrorCode+"\n";errMsg+="ErrorType: "+errorType+"       \n";errMsg+="Message: "+args.ErrorMessage+"     \n";if(errorType=="ParserError")
{errMsg+="XamlFile: "+args.xamlFile+"     \n";errMsg+="Line: "+args.lineNumber+"     \n";errMsg+="Position: "+args.charPosition+"     \n";}
else if(errorType=="RuntimeError")
{if(args.lineNumber!=0)
{errMsg+="Line: "+args.lineNumber+"     \n";errMsg+="Position: "+args.charPosition+"     \n";}
errMsg+="MethodName: "+args.methodName+"     \n";}
alert(errMsg);}
Silverlight.__cleanup=function()
{for(var i=Silverlight._silverlightCount-1;i>=0;i--){window['__slEvent'+i]=null;}
Silverlight._silverlightCount=0;if(window.removeEventListener){window.removeEventListener('unload',Silverlight.__cleanup,false);}
else{window.detachEvent('onunload',Silverlight.__cleanup);}}
Silverlight.__getHandlerName=function(handler)
{var handlerName="";if(typeof handler=="string")
{handlerName=handler;}
else if(typeof handler=="function")
{if(Silverlight._silverlightCount==0)
{if(window.addEventListener)
{window.addEventListener('onunload',Silverlight.__cleanup,false);}
else
{window.attachEvent('onunload',Silverlight.__cleanup);}}
var count=Silverlight._silverlightCount++;handlerName="__slEvent"+count;window[handlerName]=handler;}
else
{handlerName=null;}
return handlerName;}