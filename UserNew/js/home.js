﻿(function () {
    var h = {}, mt = {}, c = { id: "94662e2ab60b2e7078fcc5635b00a368", dm: ["yong01.com"], js: "tongji.baidu.com/hm-web/js/", etrk: [], icon: '', ctrk: true, align: 1, nv: -1, vdur: 1800000, age: 31536000000, rec: 0, rp: [], trust: 0, vcard: 0, qiao: 0, lxb: 0, conv: 0, comm: 0, apps: '' }; var q = !0, r = null, s = !1; mt.i = {}; mt.i.L = /msie (\d+\.\d+)/i.test(navigator.userAgent); mt.i.Da = /msie (\d+\.\d+)/i.test(navigator.userAgent) ? document.documentMode || +RegExp.$1 : void 0; mt.i.cookieEnabled = navigator.cookieEnabled; mt.i.javaEnabled = navigator.javaEnabled(); mt.i.language = navigator.language || navigator.browserLanguage || navigator.systemLanguage || navigator.userLanguage || ""; mt.i.Ja = (window.screen.width || 0) + "x" + (window.screen.height || 0); mt.i.colorDepth = window.screen.colorDepth || 0; mt.cookie = {};
    mt.cookie.set = function (a, b, f) { var e; f.I && (e = new Date, e.setTime(e.getTime() + f.I)); document.cookie = a + "=" + b + (f.domain ? "; domain=" + f.domain : "") + (f.path ? "; path=" + f.path : "") + (e ? "; expires=" + e.toGMTString() : "") + (f.$a ? "; secure" : "") }; mt.cookie.get = function (a) { return (a = RegExp("(^| )" + a + "=([^;]*)(;|$)").exec(document.cookie)) ? a[2] : r }; mt.r = {}; mt.r.Ta = function (a) { return document.getElementById(a) }; mt.r.oa = function (a) { var b; for (b = "A"; (a = a.parentNode) && 1 == a.nodeType;) if (a.tagName == b) return a; return r };
    (mt.r.Ha = function () {
        function a() { if (!a.C) { a.C = q; for (var b = 0, d = e.length; b < d; b++) e[b]() } } function b() { try { document.documentElement.doScroll("left") } catch (e) { setTimeout(b, 1); return } a() } var f = s, e = [], d; document.addEventListener ? d = function () { document.removeEventListener("DOMContentLoaded", d, s); a() } : document.attachEvent && (d = function () { "complete" === document.readyState && (document.detachEvent("onreadystatechange", d), a()) }); (function () {
            if (!f) if (f = q, "complete" === document.readyState) a.C = q; else if (document.addEventListener) document.addEventListener("DOMContentLoaded",
            d, s), window.addEventListener("load", a, s); else if (document.attachEvent) { document.attachEvent("onreadystatechange", d); window.attachEvent("onload", a); var e = s; try { e = window.frameElement == r } catch (n) { } document.documentElement.doScroll && e && b() }
        })(); return function (b) { a.C ? b() : e.push(b) }
    }()).C = s; mt.event = {}; mt.event.c = function (a, b, f) { a.attachEvent ? a.attachEvent("on" + b, function (e) { f.call(a, e) }) : a.addEventListener && a.addEventListener(b, f, s) };
    mt.event.preventDefault = function (a) { a.preventDefault ? a.preventDefault() : a.returnValue = s }; mt.l = {}; mt.l.parse = function () { return (new Function('return (" + source + ")'))() };
    mt.l.stringify = function () {
        function a(a) { /["\\\x00-\x1f]/.test(a) && (a = a.replace(/["\\\x00-\x1f]/g, function (a) { var b = f[a]; if (b) return b; b = a.charCodeAt(); return "\\u00" + Math.floor(b / 16).toString(16) + (b % 16).toString(16) })); return '"' + a + '"' } function b(a) { return 10 > a ? "0" + a : a } var f = { "\b": "\\b", "\t": "\\t", "\n": "\\n", "\f": "\\f", "\r": "\\r", '"': '\\"', "\\": "\\\\" }; return function (e) {
            switch (typeof e) {
                case "undefined": return "undefined"; case "number": return isFinite(e) ? String(e) : "null"; case "string": return a(e); case "boolean": return String(e);
                default: if (e === r) return "null"; if (e instanceof Array) { var d = ["["], f = e.length, n, g, k; for (g = 0; g < f; g++) switch (k = e[g], typeof k) { case "undefined": case "function": case "unknown": break; default: n && d.push(","), d.push(mt.l.stringify(k)), n = 1 } d.push("]"); return d.join("") } if (e instanceof Date) return '"' + e.getFullYear() + "-" + b(e.getMonth() + 1) + "-" + b(e.getDate()) + "T" + b(e.getHours()) + ":" + b(e.getMinutes()) + ":" + b(e.getSeconds()) + '"'; n = ["{"]; g = mt.l.stringify; for (f in e) if (Object.prototype.hasOwnProperty.call(e, f)) switch (k =
                e[f], typeof k) { case "undefined": case "unknown": case "function": break; default: d && n.push(","), d = 1, n.push(g(f) + ":" + g(k)) } n.push("}"); return n.join("")
            }
        }
    }(); mt.lang = {}; mt.lang.e = function (a, b) { return "[object " + b + "]" === {}.toString.call(a) }; mt.lang.Xa = function (a) { return mt.lang.e(a, "Number") && isFinite(a) }; mt.lang.Za = function (a) { return mt.lang.e(a, "String") }; mt.localStorage = {};
    mt.localStorage.G = function () { if (!mt.localStorage.g) try { mt.localStorage.g = document.createElement("input"), mt.localStorage.g.type = "hidden", mt.localStorage.g.style.display = "none", mt.localStorage.g.addBehavior("#default#userData"), document.getElementsByTagName("head")[0].appendChild(mt.localStorage.g) } catch (a) { return s } return q };
    mt.localStorage.set = function (a, b, f) { var e = new Date; e.setTime(e.getTime() + f || 31536E6); try { window.localStorage ? (b = e.getTime() + "|" + b, window.localStorage.setItem(a, b)) : mt.localStorage.G() && (mt.localStorage.g.expires = e.toUTCString(), mt.localStorage.g.load(document.location.hostname), mt.localStorage.g.setAttribute(a, b), mt.localStorage.g.save(document.location.hostname)) } catch (d) { } };
    mt.localStorage.get = function (a) { if (window.localStorage) { if (a = window.localStorage.getItem(a)) { var b = a.indexOf("|"), f = a.substring(0, b) - 0; if (f && f > (new Date).getTime()) return a.substring(b + 1) } } else if (mt.localStorage.G()) try { return mt.localStorage.g.load(document.location.hostname), mt.localStorage.g.getAttribute(a) } catch (e) { } return r };
    mt.localStorage.remove = function (a) { if (window.localStorage) window.localStorage.removeItem(a); else if (mt.localStorage.G()) try { mt.localStorage.g.load(document.location.hostname), mt.localStorage.g.removeAttribute(a), mt.localStorage.g.save(document.location.hostname) } catch (b) { } }; mt.sessionStorage = {}; mt.sessionStorage.set = function (a, b) { if (window.sessionStorage) try { window.sessionStorage.setItem(a, b) } catch (f) { } };
    mt.sessionStorage.get = function (a) { return window.sessionStorage ? window.sessionStorage.getItem(a) : r }; mt.sessionStorage.remove = function (a) { window.sessionStorage && window.sessionStorage.removeItem(a) }; mt.Q = {}; mt.Q.log = function (a, b) { var f = new Image, e = "mini_tangram_log_" + Math.floor(2147483648 * Math.random()).toString(36); window[e] = f; f.onload = f.onerror = f.onabort = function () { f.onload = f.onerror = f.onabort = r; f = window[e] = r; b && b(a) }; f.src = a }; mt.R = {};
    mt.R.wa = function () { var a = ""; if (navigator.plugins && navigator.mimeTypes.length) { var b = navigator.plugins["Shockwave Flash"]; b && b.description && (a = b.description.replace(/^.*\s+(\S+)\s+\S+$/, "$1")) } else if (window.ActiveXObject) try { if (b = new ActiveXObject("ShockwaveFlash.ShockwaveFlash")) (a = b.GetVariable("$version")) && (a = a.replace(/^.*\s+(\d+),(\d+).*$/, "$1.$2")) } catch (f) { } return a };
    mt.R.Ra = function (a, b, f, e, d) { return '<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" id="' + a + '" width="' + f + '" height="' + e + '"><param name="movie" value="' + b + '" /><param name="flashvars" value="' + (d || "") + '" /><param name="allowscriptaccess" value="always" /><embed type="application/x-shockwave-flash" name="' + a + '" width="' + f + '" height="' + e + '" src="' + b + '" flashvars="' + (d || "") + '" allowscriptaccess="always" /></object>' }; mt.url = {};
    mt.url.k = function (a, b) { var f = a.match(RegExp("(^|&|\\?|#)(" + b + ")=([^&#]*)(&|$|#)", "")); return f ? f[3] : r }; mt.url.Va = function (a) { return (a = a.match(/^(https?:)\/\//)) ? a[1] : r }; mt.url.sa = function (a) { return (a = a.match(/^(https?:\/\/)?([^\/\?#]*)/)) ? a[2].replace(/.*@/, "") : r }; mt.url.U = function (a) { return (a = mt.url.sa(a)) ? a.replace(/:\d+$/, "") : a }; mt.url.Ua = function (a) { return (a = a.match(/^(https?:\/\/)?[^\/]*(.*)/)) ? a[2].replace(/[\?#].*/, "").replace(/^$/, "/") : r };
    h.q = { Wa: "http://tongji.baidu.com/hm-web/welcome/ico", O: "hm.baidu.com/hm.gif", ca: "baidu.com", Aa: "hmmd", Ba: "hmpl", za: "hmkw", xa: "hmci", Ca: "hmsr", ya: "hmcu", p: 0, m: Math.round(+new Date / 1E3), protocol: "https:" === document.location.protocol ? "https:" : "http:", Ya: 0, ha: 6E5, ia: 10, S: 1024, ga: 1, w: 2147483647, $: "cc cf ci ck cl cm cp cu cw ds ep et fl ja ln lo lt nv rnd si st su v cv lv api tt u".split(" ") };
    (function () { var a = { o: {}, c: function (a, f) { this.o[a] = this.o[a] || []; this.o[a].push(f) }, z: function (a, f) { this.o[a] = this.o[a] || []; for (var e = this.o[a].length, d = 0; d < e; d++) this.o[a][d](f) } }; return h.A = a })();
    (function () { function a(a, e) { var d = document.createElement("script"); d.charset = "utf-8"; b.e(e, "Function") && (d.readyState ? d.onreadystatechange = function () { if ("loaded" === d.readyState || "complete" === d.readyState) d.onreadystatechange = r, e() } : d.onload = function () { e() }); d.src = a; var l = document.getElementsByTagName("script")[0]; l.parentNode.insertBefore(d, l) } var b = mt.lang; return h.load = a })();
    (function () {
        var a = mt.r, b = mt.event, f = mt.i, e = h.q, d = [], l = {
            aa: function () { c.ctrk && (b.c(document, "mouseup", l.fa()), b.c(window, "unload", function () { l.D() }), setInterval(function () { l.D() }, e.ha)) }, fa: function () { return function (a) { a = l.pa(a); if ("" !== a) { var b = (e.protocol + "//" + e.O + "?" + h.b.Z().replace(/ep=[^&]*/, "ep=" + encodeURIComponent("[" + a + "]"))).length; b + (e.w + "").length > e.S || (b + encodeURIComponent(d.join(",") + (d.length ? "," : "")).length + (e.w + "").length > e.S && l.D(), d.push(a), (d.length >= e.ia || /t:a/.test(a)) && l.D()) } } },
            pa: function (b) {
                if (0 === e.ga) { var d = b.target || b.srcElement, k = d.tagName.toLowerCase(); if ("embed" == k || "object" == k) return "" } f.L ? (d = Math.max(document.documentElement.scrollTop, document.body.scrollTop), k = Math.max(document.documentElement.scrollLeft, document.body.scrollLeft), k = b.clientX + k, d = b.clientY + d) : (k = b.pageX, d = b.pageY); var m = window.innerWidth || document.documentElement.clientWidth || document.body.offsetWidth; switch (c.align) { case 1: k -= m / 2; break; case 2: k -= m } k = "{x:" + k + ",y:" + d + ","; d = b.target || b.srcElement;
                return k = (b = "a" == d.tagName.toLowerCase() ? d : a.oa(d)) ? k + ("t:a,u:" + encodeURIComponent(b.href) + "}") : k + "t:b}"
            }, D: function () { 0 !== d.length && (h.b.a.et = 2, h.b.a.ep = "[" + d.join(",") + "]", h.b.j(), d = []) }
        }; h.A.c("pv-b", l.aa); return l
    })();
    (function () {
        function a() { return function () { h.b.a.nv = 0; h.b.a.st = 4; h.b.a.et = 3; h.b.a.ep = h.H.ua() + "," + h.H.ra(); h.b.j() } } function b() { clearTimeout(x); var a; w && (a = "visible" == document[w]); y && (a = !document[y]); g = "undefined" == typeof a ? q : a; if ((!n || !k) && g && m) u = q, p = +new Date; else if (n && k && (!g || !m)) u = s, t += +new Date - p; n = g; k = m; x = setTimeout(b, 100) } function f(a) {
            var k = document, p = ""; if (a in k) p = a; else for (var b = ["webkit", "ms", "moz", "o"], d = 0; d < b.length; d++) {
                var e = b[d] + a.charAt(0).toUpperCase() + a.slice(1); if (e in k) {
                    p =
                    e; break
                }
            } return p
        } function e(a) { if (!("focus" == a.type || "blur" == a.type) || !(a.target && a.target != window)) m = "focus" == a.type || "focusin" == a.type ? q : s, b() } var d = mt.event, l = h.A, n = q, g = q, k = q, m = q, v = +new Date, p = v, t = 0, u = q, w = f("visibilityState"), y = f("hidden"), x; b(); (function () {
            var a = w.replace(/[vV]isibilityState/, "visibilitychange"); d.c(document, a, b); d.c(window, "pageshow", b); d.c(window, "pagehide", b); "object" == typeof document.onfocusin ? (d.c(document, "focusin", e), d.c(document, "focusout", e)) : (d.c(window, "focus", e),
            d.c(window, "blur", e))
        })(); h.H = { ua: function () { return +new Date - v }, ra: function () { return u ? +new Date - p + t : t } }; l.c("pv-b", function () { d.c(window, "unload", a()) }); return h.H
    })();
    (function () { var a = mt.lang, b = h.q, f = h.load, e = { Ea: function (d) { if ((void 0 === window._dxt || a.e(window._dxt, "Array")) && "undefined" !== typeof h.b) { var e = h.b.J(); f([b.protocol, "//datax.baidu.com/x.js?si=", c.id, "&dm=", encodeURIComponent(e)].join(""), d) } }, Pa: function (b) { if (a.e(b, "String") || a.e(b, "Number")) window._dxt = window._dxt || [], window._dxt.push(["_setUserId", b]) } }; return h.ka = e })();
    (function () {
        function a(k) { for (var b in k) if ({}.hasOwnProperty.call(k, b)) { var d = k[b]; f.e(d, "Object") || f.e(d, "Array") ? a(d) : k[b] = String(d) } } function b(a) { return a.replace ? a.replace(/'/g, "'0").replace(/\*/g, "'1").replace(/!/g, "'2") : a } var f = mt.lang, e = mt.l, d = h.q, l = h.A, n = h.ka, g = {
            s: [], F: 0, X: s, init: function () { g.d = 0; l.c("pv-b", function () { g.la(); g.ma() }); l.c("pv-d", g.na); l.c("stag-b", function () { h.b.a.api = g.d || g.F ? g.d + "_" + g.F : "" }); l.c("stag-d", function () { h.b.a.api = 0; g.d = 0; g.F = 0 }) }, la: function () {
                var a = window._hmt ||
                []; if (!a || f.e(a, "Array")) window._hmt = { id: c.id, cmd: {}, push: function () { for (var a = window._hmt, k = 0; k < arguments.length; k++) { var p = arguments[k]; f.e(p, "Array") && (a.cmd[a.id].push(p), "_setAccount" === p[0] && (1 < p.length && /^[0-9a-f]{32}$/.test(p[1])) && (p = p[1], a.id = p, a.cmd[p] = a.cmd[p] || [])) } } }, window._hmt.cmd[c.id] = [], window._hmt.push.apply(window._hmt, a)
            }, ma: function () {
                var a = window._hmt; if (a && a.cmd && a.cmd[c.id]) for (var b = a.cmd[c.id], d = /^_track(Event|MobConv|Order|RTEvent)$/, p = 0, e = b.length; p < e; p++) {
                    var f = b[p];
                    d.test(f[0]) ? g.s.push(f) : g.N(f)
                } a.cmd[c.id] = { push: g.N }
            }, na: function () { if (0 < g.s.length) for (var a = 0, b = g.s.length; a < b; a++) g.N(g.s[a]); g.s = r }, N: function (a) { var b = a[0]; if (g.hasOwnProperty(b) && f.e(g[b], "Function")) g[b](a) }, _setAccount: function (a) { 1 < a.length && /^[0-9a-f]{32}$/.test(a[1]) && (g.d |= 1) }, _setAutoPageview: function (a) { if (1 < a.length && (a = a[1], s === a || q === a)) g.d |= 2, h.b.V = a }, _trackPageview: function (a) {
                if (1 < a.length && a[1].charAt && "/" === a[1].charAt(0)) {
                    g.d |= 4; h.b.a.et = 0; h.b.a.ep = ""; h.b.K ? (h.b.a.nv = 0, h.b.a.st =
                    4) : h.b.K = q; var b = h.b.a.u, e = h.b.a.su; h.b.a.u = d.protocol + "//" + document.location.host + a[1]; g.X || (h.b.a.su = document.location.href); h.b.j(); h.b.a.u = b; h.b.a.su = e
                }
            }, _trackEvent: function (a) { 2 < a.length && (g.d |= 8, h.b.a.nv = 0, h.b.a.st = 4, h.b.a.et = 4, h.b.a.ep = b(a[1]) + "*" + b(a[2]) + (a[3] ? "*" + b(a[3]) : "") + (a[4] ? "*" + b(a[4]) : ""), h.b.j()) }, _setCustomVar: function (a) {
                if (!(4 > a.length)) {
                    var d = a[1], e = a[4] || 3; if (0 < d && 6 > d && 0 < e && 4 > e) {
                        g.F++; for (var p = (h.b.a.cv || "*").split("!"), t = p.length; t < d - 1; t++) p.push("*"); p[d - 1] = e + "*" + b(a[2]) +
                        "*" + b(a[3]); h.b.a.cv = p.join("!"); a = h.b.a.cv.replace(/[^1](\*[^!]*){2}/g, "*").replace(/((^|!)\*)+$/g, ""); "" !== a ? h.b.setData("Hm_cv_" + c.id, encodeURIComponent(a), c.age) : h.b.Ia("Hm_cv_" + c.id)
                    }
                }
            }, _setReferrerOverride: function (a) { 1 < a.length && (h.b.a.su = a[1].charAt && "/" === a[1].charAt(0) ? d.protocol + "//" + window.location.host + a[1] : a[1], g.X = q) }, _trackOrder: function (b) { b = b[1]; f.e(b, "Object") && (a(b), g.d |= 16, h.b.a.nv = 0, h.b.a.st = 4, h.b.a.et = 94, h.b.a.ep = e.stringify(b), h.b.j()) }, _trackMobConv: function (a) {
                if (a = {
                    webim: 1,
                    tel: 2, map: 3, sms: 4, callback: 5, share: 6
                }[a[1]]) g.d |= 32, h.b.a.et = 93, h.b.a.ep = a, h.b.j()
            }, _trackRTPageview: function (b) { b = b[1]; f.e(b, "Object") && (a(b), b = e.stringify(b), 512 >= encodeURIComponent(b).length && (g.d |= 64, h.b.a.rt = b)) }, _trackRTEvent: function (b) {
                b = b[1]; if (f.e(b, "Object")) {
                    a(b); b = encodeURIComponent(e.stringify(b)); var m = function (a) { var b = h.b.a.rt; g.d |= 128; h.b.a.et = 90; h.b.a.rt = a; h.b.j(); h.b.a.rt = b }, l = b.length; if (900 >= l) m.call(this, b); else for (var l = Math.ceil(l / 900), p = "block|" + Math.round(Math.random() *
                    d.w).toString(16) + "|" + l + "|", t = [], u = 0; u < l; u++) t.push(u), t.push(b.substring(900 * u, 900 * u + 900)), m.call(this, p + t.join("|")), t = []
                }
            }, _setUserId: function (a) { a = a[1]; n.Ea(); n.Pa(a) }
        }; g.init(); h.da = g; return h.da
    })();
    (function () {
        function a() { "undefined" === typeof window["_bdhm_loaded_" + c.id] && (window["_bdhm_loaded_" + c.id] = q, this.a = {}, this.V = q, this.K = s, this.init()) } var b = mt.url, f = mt.Q, e = mt.R, d = mt.lang, l = mt.cookie, n = mt.i, g = mt.localStorage, k = mt.sessionStorage, m = h.q, v = h.A; a.prototype = {
            M: function (a, b) { a = "." + a.replace(/:\d+/, ""); b = "." + b.replace(/:\d+/, ""); var d = a.indexOf(b); return -1 < d && d + b.length === a.length }, Y: function (a, b) { a = a.replace(/^https?:\/\//, ""); return 0 === a.indexOf(b) }, B: function (a) {
                for (var d = 0; d < c.dm.length; d++) if (-1 <
                c.dm[d].indexOf("/")) { if (this.Y(a, c.dm[d])) return q } else { var e = b.U(a); if (e && this.M(e, c.dm[d])) return q } return s
            }, J: function () { for (var a = document.location.hostname, b = 0, d = c.dm.length; b < d; b++) if (this.M(a, c.dm[b])) return c.dm[b].replace(/(:\d+)?[\/\?#].*/, ""); return a }, T: function () { for (var a = 0, b = c.dm.length; a < b; a++) { var d = c.dm[a]; if (-1 < d.indexOf("/") && this.Y(document.location.href, d)) return d.replace(/^[^\/]+(\/.*)/, "$1") + "/" } return "/" }, va: function () {
                if (!document.referrer) return m.m - m.p > c.vdur ? 1 : 4; var a =
                s; this.B(document.referrer) && this.B(document.location.href) ? a = q : (a = b.U(document.referrer), a = this.M(a || "", document.location.hostname)); return a ? m.m - m.p > c.vdur ? 1 : 4 : 3
            }, getData: function (a) { try { return l.get(a) || k.get(a) || g.get(a) } catch (b) { } }, setData: function (a, b, d) { try { l.set(a, b, { domain: this.J(), path: this.T(), I: d }), d ? g.set(a, b, d) : k.set(a, b) } catch (e) { } }, Ia: function (a) { try { l.set(a, "", { domain: this.J(), path: this.T(), I: -1 }), k.remove(a), g.remove(a) } catch (b) { } }, Na: function () {
                var a, b, d, e, f; m.p = this.getData("Hm_lpvt_" +
                c.id) || 0; 13 === m.p.length && (m.p = Math.round(m.p / 1E3)); b = this.va(); a = 4 !== b ? 1 : 0; if (d = this.getData("Hm_lvt_" + c.id)) { e = d.split(","); for (f = e.length - 1; 0 <= f; f--) 13 === e[f].length && (e[f] = "" + Math.round(e[f] / 1E3)); for (; 2592E3 < m.m - e[0];) e.shift(); f = 4 > e.length ? 2 : 3; for (1 === a && e.push(m.m) ; 4 < e.length;) e.shift(); d = e.join(","); e = e[e.length - 1] } else d = m.m, e = "", f = 1; this.setData("Hm_lvt_" + c.id, d, c.age); this.setData("Hm_lpvt_" + c.id, m.m); d = m.m === this.getData("Hm_lpvt_" + c.id) ? "1" : "0"; if (0 === c.nv && this.B(document.location.href) &&
                ("" === document.referrer || this.B(document.referrer))) a = 0, b = 4; this.a.nv = a; this.a.st = b; this.a.cc = d; this.a.lt = e; this.a.lv = f
            }, Z: function () { for (var a = [], b = 0, d = m.$.length; b < d; b++) { var e = m.$[b], f = this.a[e]; "undefined" !== typeof f && "" !== f && a.push(e + "=" + encodeURIComponent(f)) } b = this.a.et; this.a.rt && (0 === b ? a.push("rt=" + encodeURIComponent(this.a.rt)) : 90 === b && a.push("rt=" + this.a.rt)); return a.join("&") }, Oa: function () {
                this.Na(); this.a.si = c.id; this.a.su = document.referrer; this.a.ds = n.Ja; this.a.cl = n.colorDepth + "-bit";
                this.a.ln = n.language; this.a.ja = n.javaEnabled ? 1 : 0; this.a.ck = n.cookieEnabled ? 1 : 0; this.a.lo = "number" === typeof _bdhm_top ? 1 : 0; this.a.fl = e.wa(); this.a.v = "1.1.16"; this.a.cv = decodeURIComponent(this.getData("Hm_cv_" + c.id) || ""); 1 === this.a.nv && (this.a.tt = document.title || ""); var a = document.location.href; this.a.cm = b.k(a, m.Aa) || ""; this.a.cp = b.k(a, m.Ba) || ""; this.a.cw = b.k(a, m.za) || ""; this.a.ci = b.k(a, m.xa) || ""; this.a.cf = b.k(a, m.Ca) || ""; this.a.cu = b.k(a, m.ya) || ""
            }, init: function () {
                try {
                    this.Oa(), 0 === this.a.nv ? this.La() :
                    this.P(".*"), h.b = this, this.ea(), v.z("pv-b"), this.Ka()
                } catch (a) { var b = []; b.push("si=" + c.id); b.push("n=" + encodeURIComponent(a.name)); b.push("m=" + encodeURIComponent(a.message)); b.push("r=" + encodeURIComponent(document.referrer)); f.log(m.protocol + "//" + m.O + "?" + b.join("&")) }
            }, Ka: function () { function a() { v.z("pv-d") } this.V ? (this.K = q, this.a.et = 0, this.a.ep = "", this.j(a)) : a() }, j: function (a) {
                var b = this; b.a.rnd = Math.round(Math.random() * m.w); v.z("stag-b"); var e = m.protocol + "//" + m.O + "?" + b.Z(); v.z("stag-d"); b.ba(e);
                f.log(e, function (e) { b.P(e); d.e(a, "Function") && a.call(b) })
            }, ea: function () {
                var a = document.location.hash.substring(1), d = RegExp(c.id), e = -1 < document.referrer.indexOf(m.ca), f = b.k(a, "jn"), g = /^heatlink$|^select$/.test(f); a && (d.test(a) && e && g) && (this.a.rnd = Math.round(Math.random() * m.w), a = document.createElement("script"), a.setAttribute("type", "text/javascript"), a.setAttribute("charset", "utf-8"), a.setAttribute("src", m.protocol + "//" + c.js + f + ".js?" + this.a.rnd), f = document.getElementsByTagName("script")[0], f.parentNode.insertBefore(a,
                f))
            }, ba: function (a) { var b = k.get("Hm_unsent_" + c.id) || "", d = this.a.u ? "" : "&u=" + encodeURIComponent(document.location.href), b = encodeURIComponent(a.replace(/^https?:\/\//, "") + d) + (b ? "," + b : ""); k.set("Hm_unsent_" + c.id, b) }, P: function (a) { var b = k.get("Hm_unsent_" + c.id) || ""; b && (a = encodeURIComponent(a.replace(/^https?:\/\//, "")), a = RegExp(a.replace(/([\*\(\)])/g, "\\$1") + "(%26u%3D[^,]*)?,?", "g"), (b = b.replace(a, "").replace(/,$/, "")) ? k.set("Hm_unsent_" + c.id, b) : k.remove("Hm_unsent_" + c.id)) }, La: function () {
                var a = this,
                b = k.get("Hm_unsent_" + c.id); if (b) for (var b = b.split(","), d = function (b) { f.log(m.protocol + "//" + decodeURIComponent(b), function (b) { a.P(b) }) }, e = 0, g = b.length; e < g; e++) d(b[e])
            }
        }; return new a
    })();
    (function () {
        var a = mt.r, b = mt.event, f = mt.url, e = mt.l; try {
            if (window.performance && performance.timing && "undefined" !== typeof h.b) {
                var d = +new Date, l = function (a) { var b = performance.timing, d = b[a + "Start"] ? b[a + "Start"] : 0; a = b[a + "End"] ? b[a + "End"] : 0; return { start: d, end: a, value: 0 < a - d ? a - d : 0 } }, n = r; a.Ha(function () { n = +new Date }); var g = function () {
                    var a, b, g; g = l("navigation"); b = l("request"); g = {
                        netAll: b.start - g.start, netDns: l("domainLookup").value, netTcp: l("connect").value, srv: l("response").start - b.start, dom: performance.timing.domInteractive -
                        performance.timing.fetchStart, loadEvent: l("loadEvent").end - g.start
                    }; a = document.referrer; var k = a.match(/^(http[s]?:\/\/)?([^\/]+)(.*)/) || [], u = r; b = r; if ("www.baidu.com" === k[2] || "m.baidu.com" === k[2]) u = f.k(a, "qid"), b = f.k(a, "click_t"); a = u; g.qid = a != r ? a : ""; b != r ? (g.bdDom = n ? n - b : 0, g.bdRun = d - b, g.bdDef = l("navigation").start - b) : (g.bdDom = 0, g.bdRun = 0, g.bdDef = 0); h.b.a.et = 87; h.b.a.ep = e.stringify(g); h.b.j()
                }; b.c(window, "load", function () { setTimeout(g, 500) })
            }
        } catch (k) { }
    })();
    (function () { var a = h.q, b = { init: function () { try { if ("http:" === a.protocol) { var b = document.createElement("IFRAME"); b.setAttribute("src", "http://boscdn.bpc.baidu.com/v1/holmes-moplus/mp-cdn.html"); b.style.display = "none"; b.style.width = "1"; b.style.height = "1"; b.Sa = "0"; document.body.appendChild(b) } } catch (d) { } } }, f = navigator.userAgent.toLowerCase(); -1 < f.indexOf("android") && -1 === f.indexOf("micromessenger") && b.init() })();
    (function () {
        var a = mt.i, b = mt.lang, f = mt.event, e = mt.l; if ("undefined" !== typeof h.b && (c.comm || !a.L || 7 < a.Da)) {
            var d, l, n, g, k = function (a) { if (a.item) { for (var b = a.length, d = Array(b) ; b--;) d[b] = a[b]; return d } return [].slice.call(a) }, m = function (a, b) { for (var d in a) if (a.hasOwnProperty(d) && b.call(a, d, a[d]) === s) return s }, v = function (a, f) {
                var g = {}; g.n = d; g.t = "clk"; g.v = a; if (f) {
                    var l = f.getAttribute("href"), k = f.getAttribute("onclick") ? "" + f.getAttribute("onclick") : r, m = f.getAttribute("id") || ""; n.test(l) ? (g.sn = "mediate", g.snv =
                    l) : b.e(k, "String") && n.test(k) && (g.sn = "wrap", g.snv = k); g.id = m
                } h.b.a.et = 86; h.b.a.ep = e.stringify(g); h.b.j(); for (g = +new Date; 400 >= +new Date - g;);
            }; if (c.comm) l = "/zoosnet", d = "swt", n = /swt|zixun|call|chat|zoos|business|talk|kefu|openkf|online|\/LR\/Chatpre\.aspx/i, g = {
                click: function () {
                    for (var a = [], b = k(document.getElementsByTagName("a")), b = [].concat.apply(b, k(document.getElementsByTagName("area"))), b = [].concat.apply(b, k(document.getElementsByTagName("img"))), d, e, f = 0, g = b.length; f < g; f++) d = b[f], e = d.getAttribute("onclick"),
                    d = d.getAttribute("href"), (n.test(e) || n.test(d)) && a.push(b[f]); return a
                }
            }; else {
                l = "/other-comm"; d = "other"; n = /tencent:\/\/|qq\.(com|htm)|kefu|openkf|swt|zoos|53kf|doyoo|looyu|leyu|zixun|chat|talk|openQQ|open_ask|online/i; var p = /doyoo_mon_accept|d_panel_accept|contactR|^looyu_dom_\d*$/; g = {
                    click: function () {
                        for (var a = [], b = k(document.getElementsByTagName("a")), b = [].concat.apply(b, k(document.getElementsByTagName("area"))), b = [].concat.apply(b, k(document.getElementsByTagName("img"))), d, e, f, g = 0, l = b.length; g <
                        l; g++) d = b[g], e = d.getAttribute("onclick"), f = d.getAttribute("href"), d = d.getAttribute("id"), (n.test(e) || n.test(f) || p.test(d)) && a.push(b[g]); return a
                    }
                }
            } if ("undefined" !== typeof g && "undefined" !== typeof n) {
                var t; l += /\/$/.test(l) ? "" : "/"; var u = function (a, d) { if (t === d) return v(l + a, d), s; if (b.e(d, "Array") || b.e(d, "NodeList")) for (var e = 0, f = d.length; e < f; e++) if (t === d[e]) return v(l + a + "/" + (e + 1), d[e]), s }; f.c(document, "mousedown", function (a) {
                    a = a || window.event; t = a.target || a.srcElement; var d = {}; for (m(g, function (a, e) {
                    d[a] =
                    b.e(e, "Function") ? e() : document.getElementById(e)
                    }) ; t && t !== document && m(d, u) !== s;) t = t.parentNode
                })
            }
        }
    })(); (function () { var a = mt.event, b = mt.l; if (c.comm && "undefined" !== typeof h.b) { var f = +new Date, e = { n: "anti", sb: 0, kb: 0, clk: 0 }, d = function () { h.b.a.et = 86; h.b.a.ep = b.stringify(e); h.b.j() }; a.c(document, "click", function () { e.clk++ }); a.c(document, "keyup", function () { e.kb = 1 }); a.c(window, "scroll", function () { e.sb++ }); a.c(window, "unload", function () { e.t = +new Date - f; d() }); a.c(window, "load", function () { setTimeout(d, 5E3) }) } })();
    (function () {
        function a() { this.f = r } var b = mt.Q, f = mt.i; a.prototype = {
            Fa: function (a) { if (this.f) this.h(a, 0); else if (this.isSupported()) { try { this.f = new ActiveXObject("BDEXIE.BDExExtension.1"), this.W = q } catch (b) { this.W = s } this.W ? this.h(a, 0) : this.h(a, -1) } else this.h(a, -1) }, Qa: function () { this.f && delete this.f; this.f = r }, Ma: function (a, b, e) { if (this.f && "SetLocalCache" in this.f) try { void 0 === this.f.SetLocalCache(a, b) && this.h(e, 0) } catch (f) { this.h(e, -1) } else this.h(e, -1) }, ta: function (a, b) {
                if (this.f && "GetLocalCache" in
                this.f) try { this.h(b, this.f.GetLocalCache(a)) } catch (e) { this.h(b, "") } else this.h(b, "")
            }, qa: function (a) { if (this.f && "GetCryptStr" in this.f) try { this.h(a, this.f.GetCryptStr("strEncryptID1")) } catch (b) { this.h(a, "") } else this.h(a, "") }, h: function (a, b) { "function" === typeof a && a(b, this) }, isSupported: function () { if (window.ActiveXObject || "ActiveXObject" in window) try { return !!new ActiveXObject("BDEXIE.BDExExtension.1") } catch (a) { } return s }, Ga: function () {
                var a = this; this.qa(function (e) {
                    void 0 !== e && "" !== e && (b.log("//datax.baidu.com/x.gif?dm=" +
                    encodeURIComponent("datax.baidu.com/webadapter/guid") + "&ac=" + encodeURIComponent(e) + "&v=hm-webadapter-0.0.1&rnd=" + Math.round(2147483647 * Math.random())), a.Ma("hmKey", +new Date, function () { a.Qa() }))
                })
            }
        }; if (f.L && /^http(s)?:$/.test(document.location.protocol)) { var e = new a; e.Fa(function (a) { 0 === a && e.ta("hmKey", function (a) { a = +a; (isNaN(a) || 6048E5 < +new Date - a) && e.Ga() }) }) }
    })();
})();
