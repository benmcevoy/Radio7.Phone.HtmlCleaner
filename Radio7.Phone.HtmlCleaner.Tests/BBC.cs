﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Radio7.Phone.HtmlCleaner.Tests
{
    internal class BBC
    {
        public static HtmlDocument HtmlDocument
        {
            get
            {
                var htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(Html);
                return htmlDocument;
            }
        }

        public static string Html
        {
            get
            {
                return @"
<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML+RDFa 1.0//EN"" ""http://www.w3.org/MarkUp/DTD/xhtml-rdfa-1.dtd"">




<!-- contentApiRelativeUrl is '/news/uk-23119325', audience is (none) -->
    


 
    







    
    

<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:og=""http://opengraphprotocol.org/schema/"" xmlns:rnews=""http://iptc.org/std/rNews/2011-10-07#"" xml:lang=""en-GB"">
        
    
    
    
	
    
    
    
    
    
    
    
	
    
	
    
	
	
	
	
    
	
    
        
    
<!-- THIS FILE CONFIGURES SHARED HIGHWEB STATIC ASSETS -->





<!-- mapping_news.inc -->
<!-- THIS FILE CONFIGURES NEWS STATIC ASSETS  -->




<!-- THIS FILE CONFIGURES VOTE 2012 STATIC ASSETS  -->





    <!-- hi/shared/head_initial.inc -->



	


	        <head profile=""http://dublincore.org/documents/dcq-html/"" resource=""http://www.bbc.co.uk/news/uk-23119325"" typeof=""rnews:NewsItem"">
        <meta http-equiv=""X-UA-Compatible"" content=""IE=8"" />
        <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
        <title>BBC News - Cameron urges Pakistan union on terror </title>
        <meta name=""Description"" content=""David Cameron says that Britain will &quot;stand together&quot; with Pakistan in the fight against terrorism, following talks with Pakistan&#039;s newly-elected prime minister Nawaz Sharif.""/>
        <meta property=""rnews:description"" content=""David Cameron says that Britain will &quot;stand together&quot; with Pakistan in the fight against terrorism, following talks with Pakistan&#039;s newly-elected prime minister Nawaz Sharif.""/>
                <meta name=""OriginalPublicationDate"" content=""2013/06/30 12:37:53""/>
        <meta property=""rnews:datePublished"" content=""2013/06/30 12:37:53""/>
        <meta name=""UKFS_URL"" content=""/news/uk-23119325""/>
                <meta name=""THUMBNAIL_URL"" content=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465210_68465130.jpg""/>
        <meta property=""rnews:thumbnailUrl"" content=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465210_68465130.jpg""/>
                <meta name=""Headline"" content=""Cameron urges Pakistan union on terror ""/>
        <meta property=""rnews:headline"" content=""Cameron urges Pakistan union on terror ""/>
        <meta name=""IFS_URL"" content=""/news/uk-23119325""/>
        <meta name=""Section"" content=""UK""/>
        <meta name=""contentFlavor"" content=""STORY""/>
		                        <meta name=""CPS_ID"" content=""23119325"" />
        <meta name=""CPS_SITE_NAME"" content=""BBC News"" />
        <meta name=""CPS_SECTION_PATH"" content=""UK"" />
        <meta name=""CPS_ASSET_TYPE"" content=""MAP"" />
        <meta name=""CPS_PLATFORM"" content=""HighWeb"" />
        <meta name=""CPS_AUDIENCE"" content=""International"" />
        <meta property=""rnews:creator"" content=""http://www.bbc.co.uk#org""/>        
        
            		<meta property=""og:title"" content=""Cameron urges Pakistan union on terror ""/>
    		<meta property=""og:type"" content=""article""/>
    		<meta property=""og:url"" content=""http://www.bbc.co.uk/news/uk-23119325""/>
    		<meta property=""og:site_name"" content=""BBC News""/>
            			<meta property=""og:image"" content=""http://newsimg.bbc.co.uk/media/images/67373000/jpg/_67373987_09f1654a-e583-4b5f-bfc4-f05850c6d3ce.jpg""/>
											        
					<meta name=""bbcsearch_noindex"" content=""emp""/>
							
															
		    		
        <link rel=""canonical"" href=""http://www.bbc.co.uk/news/uk-23119325"" />
       	        		        
        
        
            <link rel=""stylesheet"" href=""http://static.bbci.co.uk/news/1.10.1-325/stylesheets/services/journalism/holepunch.css"">
            <!--[if IE]>
                <link rel=""stylesheet"" href=""http://static.bbci.co.uk/news/1.10.1-325/stylesheets/services/journalism/holepunch-ie.css"">
            <![endif]-->
        
        
        <!-- hi/news/head_first.inc -->
<meta name=""application-name"" content=""BBC News"" />
<meta name=""msapplication-TileImage"" content=""/img/1_0_2/cream/hi/news/bbc-news-pin.png"" />
<meta name=""msapplication-TileColor"" content=""#CC0101"" />
<meta name=""twitter:card"" value=""summary"" />
 
        
<!-- PULSE_ENABLED:yes -->
























	
	
	
		
		
	








	
			
		
	
	
	
	
	
	
	
	
	
	
	
	
	
	
		
	
		





	
		

    
   <meta http-equiv=""X-UA-Compatible"" content=""IE=8"" />  
  <link rel=""schema.dcterms"" href=""http://purl.org/dc/terms/"" />  <link rel=""index"" href=""http://www.bbc.co.uk/a-z/"" title=""A to Z"" /> <link rel=""copyright"" href=""http://www.bbc.co.uk/terms/"" title=""Terms of Use"" /> <link rel=""icon"" href=""http://www.bbc.co.uk/favicon.ico"" type=""image/x-icon"" />  <meta name=""viewport"" content=""width = 996"" /> 

 <link rel=""stylesheet"" type=""text/css"" href=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/style/main.css""  />  <script type=""text/javascript"">/*<![CDATA[*/ if (typeof bbccookies_flag === 'undefined') { bbccookies_flag = 'ON'; } showCTA_flag = false; cta_enabled = (showCTA_flag && (bbccookies_flag === 'ON') ); (function(){var e=""ckns_policy"",m=""Thu, 01 Jan 1970 00:00:00 GMT"",k={ads:true,personalisation:true,performance:true,necessary:true};function f(p){if(f.cache[p]){return f.cache[p]}var o=p.split(""/""),q=[""""];do{q.unshift((o.join(""/"")||""/""));o.pop()}while(q[0]!==""/"");f.cache[p]=q;return q}f.cache={};function a(p){if(a.cache[p]){return a.cache[p]}var q=p.split("".""),o=[];while(q.length&&""|co.uk|com|"".indexOf(""|""+q.join(""."")+""|"")===-1){if(q.length){o.push(q.join("".""))}q.shift()}f.cache[p]=o;return o}a.cache={};function i(o,t,p){var z=[""""].concat(a(window.location.hostname)),w=f(window.location.pathname),y="""",r,x;for(var s=0,v=z.length;s<v;s++){r=z[s];for(var q=0,u=w.length;q<u;q++){x=w[q];y=o+""=""+t+"";""+(r?""domain=""+r+"";"":"""")+(x?""path=""+x+"";"":"""")+(p?""expires=""+p+"";"":"""");bbccookies.set(y,true)}}}window.bbccookies={_setEverywhere:i,cookiesEnabled:function(){var o=""ckns_testcookie""+Math.floor(Math.random()*100000);this.set(o+""=1"");if(this.get().indexOf(o)>-1){g(o);return true}return false},set:function(o){return document.cookie=o},get:function(){return document.cookie},_setPolicy:function(o){return h.apply(this,arguments)},readPolicy:function(o){return b.apply(this,arguments)},_deletePolicy:function(){i(e,"""",m)},isAllowed:function(){return true},_isConfirmed:function(){return c()!==null},_acceptsAll:function(){var o=b();return o&&!(j(o).indexOf(""0"")>-1)},_getCookieName:function(){return d.apply(this,arguments)},_showPrompt:function(){return(!this._isConfirmed()&&window.cta_enabled&&this.cookiesEnabled()&&!window.bbccookies_disable)}};bbccookies._getPolicy=bbccookies.readPolicy;function d(p){var o=(""""+p).match(/^([^=]+)(?==)/);return(o&&o.length?o[0]:"""")}function j(o){return""""+(o.ads?1:0)+(o.personalisation?1:0)+(o.performance?1:0)}function h(r){if(typeof r===""undefined""){r=k}if(typeof arguments[0]===""string""){var o=arguments[0],q=arguments[1];if(o===""necessary""){q=true}r=b();r[o]=q}else{if(typeof arguments[0]===""object""){r.necessary=true}}var p=new Date();p.setYear(p.getFullYear()+1);p=p.toUTCString();bbccookies.set(e+""=""+j(r)+"";domain=bbc.co.uk;path=/;expires=""+p+"";"");bbccookies.set(e+""=""+j(r)+"";domain=bbc.com;path=/;expires=""+p+"";"");return r}function l(o){if(o===null){return null}var p=o.split("""");return{ads:!!+p[0],personalisation:!!+p[1],performance:!!+p[2],necessary:true}}function c(){var o=new RegExp(""(?:^|; ?)""+e+""=(\\d\\d\\d)($|;)""),p=document.cookie.match(o);if(!p){return null}return p[1]}function b(o){var p=l(c());if(!p){p=k}if(o){return p[o]}else{return p}}function g(o){return document.cookie=o+""=;expires=""+m+"";""}function n(){var o='<script type=""text/javascript"" src=""http://static.bbci.co.uk/frameworks/bbccookies/0.5.9/script/bbccookies.js""><\/script>';if(window.bbccookies_flag===""ON""&&!bbccookies._acceptsAll()&&!window.bbccookies_disable){document.write(o)}}n()})(); /*]]>*/</script>      <script type=""text/javascript""> if (! window.gloader) { window.gloader = [ ""glow"", {map: ""http://node1.bbcimg.co.uk/glow/glow/map.1.7.7.js""}]; } </script>  <script type=""text/javascript"" src=""http://node1.bbcimg.co.uk/glow/gloader.0.1.6.js""></script>   <script type=""text/javascript"" src=""http://static.bbci.co.uk/frameworks/requirejs/0.13.0/sharedmodules/require.js""></script> <script type=""text/javascript"">  bbcRequireMap = {""jquery-1"":""http://static.bbci.co.uk/frameworks/jquery/0.3.0/sharedmodules/jquery-1.7.2"", ""jquery-1.4"":""http://static.bbci.co.uk/frameworks/jquery/0.3.0/sharedmodules/jquery-1.4"", ""jquery-1.9"":""http://static.bbci.co.uk/frameworks/jquery/0.3.0/sharedmodules/jquery-1.9.1"", ""swfobject-2"":""http://static.bbci.co.uk/frameworks/swfobject/0.1.10/sharedmodules/swfobject-2"", ""demi-1"":""http://static.bbci.co.uk/frameworks/demi/0.9.8/sharedmodules/demi-1"", ""gelui-1"":""http://static.bbci.co.uk/frameworks/gelui/0.9.12/sharedmodules/gelui-1"", ""cssp!gelui-1/overlay"":""http://static.bbci.co.uk/frameworks/gelui/0.9.12/sharedmodules/gelui-1/overlay.css"", ""istats-1"":""http://static.bbci.co.uk/frameworks/istats/0.16.1/modules/istats-1"", ""relay-1"":""http://static.bbci.co.uk/frameworks/relay/0.2.4/sharedmodules/relay-1"", ""clock-1"":""http://static.bbci.co.uk/frameworks/clock/0.1.9/sharedmodules/clock-1"", ""canvas-clock-1"":""http://static.bbci.co.uk/frameworks/clock/0.1.9/sharedmodules/canvas-clock-1"", ""cssp!clock-1"":""http://static.bbci.co.uk/frameworks/clock/0.1.9/sharedmodules/clock-1.css"", ""jssignals-1"":""http://static.bbci.co.uk/frameworks/jssignals/0.3.6/modules/jssignals-1"", ""jcarousel-1"":""http://static.bbci.co.uk/frameworks/jcarousel/0.1.10/modules/jcarousel-1""}; require({ baseUrl: 'http://static.bbci.co.uk/', paths: bbcRequireMap, waitSeconds: 30 }); </script>      <script type=""text/javascript"" src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/script/barlesque.js""></script>
  
<!--[if IE 6]>
        <script type=""text/javascript"">
        try {
            document.execCommand(""BackgroundImageCache"",false,true);
        } catch(e) {}
    </script>
        <style type=""text/css"">
        /* Use filters for IE6 */
        #blq-blocks a {
            background-image: none;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5//img/blq-blocks_white_alpha.png', sizingMethod='image');
        }
        .blq-masthead-focus #blq-blocks a,
        .blq-mast-text-dark #blq-blocks a {
            background-image: none;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5//img/blq-blocks_grey_alpha.png', sizingMethod='image');
        }
        #blq-nav-search button span {
            background-image: none;
            filter: progid:DXImageTransform.Microsoft.AlphaImageLoader(src='http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5//img/blq-search_grey_alpha.png', sizingMethod='image');
        }
        #blq-nav-search button img {
            position: absolute;
            left: -999em;    
        }
    </style>
<![endif]-->

<!--[if (IE 7])|(IE 8)>
    <style type=""text/css"">
        .blq-clearfix {
            display: inline-block;
        }
    </style>
<![endif]-->

<script type=""text/javascript"">
     blq.setEnvironment('live');  if (blq.setLabel) blq.setLabel('searchSuggestion', ""Search"");  if (! /bbc\.co\.uk$/i.test(window.location.hostname) ) { document.documentElement.className += ' blq-not-bbc-co-uk'; } </script>

    <script type=""text/javascript""> if (! window.gloader) { window.gloader = [ ""glow"", {map: ""http://node1.bbcimg.co.uk/glow/glow/map.1.7.7.js""}]; } </script>
    <!-- BBCDOTCOM template:server-side journalismVariant: true ipIsAdvertiseCombined: true adsEnabled: false showDotcom: true flagpole: ON -->
                         
	

        
		<!-- shared/head -->
<meta http-equiv=""imagetoolbar"" content=""no"" />
<!--[if !(lt IE 6)]>
   	<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/type.css"" />


		<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/global.css"" />


	<link rel=""stylesheet"" type=""text/css"" media=""print"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/print.css"" />

	<link rel=""stylesheet"" type=""text/css"" media=""screen and (max-device-width: 976px)"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/mobile.css"" />
	



<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/components/components.css"" />

<![endif]-->
<!--[if !IE]>-->
   	<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/type.css"" />


		<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/global.css"" />


	<link rel=""stylesheet"" type=""text/css"" media=""print"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/print.css"" />

	<link rel=""stylesheet"" type=""text/css"" media=""screen and (max-device-width: 976px)"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/mobile.css"" />
	



<link rel=""stylesheet"" type=""text/css"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/components/components.css"" />

<!--<![endif]-->
<script type=""text/javascript"">
/*<![CDATA[*/
gloader.load([""glow"",""1"",""glow.dom""],{onLoad:function(glow){glow.dom.get(""html"").addClass(""blq-js"")}});
gloader.load([""glow"",""1"",""glow.dom""],{onLoad:function(glow){glow.ready(function(){if (glow.env.gecko){var gv = glow.env.version.split(""."");for (var i=gv.length;i<4;i++){gv[i]=0;}if((gv[0]==1 && gv[1]==9 && gv[2]==0)||(gv[0]==1 && gv[1]<9)||(gv[0]<1)){glow.dom.get(""body"").addClass(""firefox-older-than-3-5"");}}});}});

window.disableFacebookSDK=true;
if (window.location.pathname.indexOf('+')>=0){window.disableFacebookSDK=true;}

/*]]>*/
</script>
<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/locationservices/locator/v4_0/locator.js""></script>

<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/core/3_3_1/bbc_fmtj.js""></script>

<script type=""text/javascript"">
<!--
	bbc.fmtj.page = {
		serverTime: 1372604193000,
		editionToServe: 'international',
		queryString: null,
		referrer: 'http://news.google.com/',
		section: 'uk',
		sectionPath: '/UK',
		siteName: 'BBC News',
		siteToServe: 'news',
		siteVersion: 'cream',
		storyId: '23119325',
		assetType: 'media_asset',
		uri: '/news/uk-23119325',
		country: 'au',
		masthead: false,
		adKeyword: null,
		templateVersion: 'v1_0'
	}
-->
</script>
<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/common/3_2_1/bbc_fmtj_common.js""></script>


<script type=""text/javascript"">$useMap({map:""http://news.bbcimg.co.uk/js/map/map_0_0_33.js""});</script>
<script type=""text/javascript"">$loadView(""0.0"",[""bbc.fmtj.view""]);</script>
<script type=""text/javascript"">$render(""livestats-heatmap"");</script>


<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/config/apps/4_7_2/bbc_fmtj_config.js""></script>




<script type=""text/javascript"">
    //<![CDATA[
        require(['jquery-1'], function($){
            
            // set up EMP once it's loaded
            var setUp = function(){
                // use our own pop out page
        	    embeddedMedia.setPopoutUrl('/player/emp/2_0_55/popout/pop.stm');

        	    // store EMP's notifyParent function
        	    var oldNotifyParent = embeddedMedia.console.notifyParent;
        	    // use our own to add livestats to popout
        	    embeddedMedia.console.notifyParent = function(childWin){
        	        oldNotifyParent(childWin);
        	        // create new live stats url
                    var liveStatsUrl = bbc.fmtj.av.emp.liveStatsForPopout($('#livestats').attr('src'));
                    var webBug = $('<img />', {
                                     id:  'livestats',
                                     src: liveStatsUrl
                                 });
                    // append it to popout
                    $(childWin.document).find('body').append(webBug);
                }
            }
                
            // check if console is available to manipulate
            if(window.embeddedMedia && window.embeddedMedia.console){
                setUp();
            }
            // otherwise emp is still loading, so add event listener
            else{
                $(document).bind('empReady', function(){
                    setUp();
                });
            }
        });
    //]]>
</script>


		
	<!-- get BUMP from cdn -->
    <script type=""text/javascript"" src=""http://emp.bbci.co.uk/emp/bump?emp=worldwide&amp;enableClear=1""></script>

<!-- load glow and required modules -->
<script type=""text/javascript"">
    //<![CDATA[
        gloader.load(['glow', '1', 'glow.dom']);
    //]]>
</script>



	<!-- pull in our emp code -->
	<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/av/emp/2_0_55/emp.js""></script>
	<!-- pull in compatibility.js -->
	<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/av/emp/2_0_55/compatibility.js""></script>


<script type=""text/javascript"">
	//<![CDATA[
	    
	
	    
	        
	    
	
	    
	        
	    
	
	    // set site specific config
	    
	        bbc.fmtj.av.emp.configs.push('news');
	    
	    
	    // when page loaded, write all created emps
	    glow.ready(function(){
			if(typeof bbcdotcom !== 'undefined' && bbcdotcom.av && bbcdotcom.av.emp){
				bbcdotcom.av.emp.configureAll();
			}
			embeddedMedia.each(function(emp){
				emp.set('enable3G', true);
				emp.setMediator('href', '{protocol}://{host}/mediaselector/5/select/version/2.0/mediaset/{mediaset}/vpid/{id}');						
			});
			embeddedMedia.writeAll();
	        // mark the emps as loaded
	        bbc.fmtj.av.emp.loaded = true;
			
			
	    });
	//]]>
</script>
<!-- Check for advertising testing -->

<meta name=""viewport"" content=""width = 996"" />



        <!-- shared/head_media_asset -->
<!-- THESE STYLESHEETS VARY ACCORDING TO PAGE CONTENT -->

<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/layout/media_asset.css"" />
<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/3_0_16/cream/hi/shared/media_asset.css"" />


<!-- js mediaAsset view -->
<script type=""text/javascript"">$loadView(""0.0"",[""bbc.fmtj.view.news.mediaAsset""]);</script>

<!-- EMP -->
<script type=""text/javascript"" src=""http://news.bbc.co.uk/js/app/av/emp/compatibility.js""></script>
<!-- /EMP -->

        
        <!-- #CREAM hi news international include head.inc -->  
                            <!-- is suitable for ads adding isadvertise ... -->
			

			 

			
	
	
<script type=""text/javascript"">/*<![CDATA[*/if(bbcdotcom===undefined){var bbcdotcom={}}bbcdotcom.objects=function(d,e,f){var b,c,a;b=d.split(""."");if(e===undefined){e=""valid""}if(f===undefined){f=window}for(c=0,a=b.length;c<a;c++){if(f[b[c]]===undefined){if(e===""create""){f[b[c]]={}}else{return false}}f=f[b[c]]}return f};bbcdotcom.objects(""bbcdotcom.stats"",""create"");if(BBC===undefined){var BBC={}}if(BBC.adverts===undefined){BBC.adverts={setZone:function(){},configure:function(){},write:function(){},show:function(){},isActive:function(){return false},setScriptRoot:function(){},setImgRoot:function(){},getAdvertTag:function(){},getSectionPath:function(){}}};/*]]>*/</script>
<meta name=""application-name"" content=""BBC""/>
<meta name=""msapplication-tooltip"" content=""Explore the BBC, for latest news, sport and weather, TV &amp; radio schedules and highlights, with nature, food, comedy, children's programmes and much more""/>

	<meta name=""msapplication-starturl"" content=""http://www.bbc.com/news/?ocid=global-news-pinned-ie9""/>

<meta name=""msapplication-window"" content=""width=1024;height=768""/>
<meta name=""msapplication-task"" content=""name=BBC Home;action-uri=http://www.bbc.com/?ocid=global-homepage-pinned-ie9;icon-uri=http://news.bbcimg.co.uk/shared/img/bbccom/favicon_16.ico"" />
<meta name=""msapplication-task"" content=""name=BBC News;action-uri=http://www.bbc.com/news/?ocid=global-news-pinned-ie9;icon-uri=http://news.bbcimg.co.uk/shared/img/bbccom/favicon_16.ico"" />
<meta name=""msapplication-task"" content=""name=BBC Sport;action-uri=http://www.bbc.com/sport/0/?ocid=global-sport-pinned-ie9;icon-uri=http://news.bbcimg.co.uk/shared/img/bbccom/favicon_16.ico"" />
<meta name=""msapplication-task"" content=""name=BBC Future;action-uri=http://www.bbc.com/future?ocid=global-future-pinned-ie9;icon-uri=http://news.bbcimg.co.uk/shared/img/bbccom/favicon_16.ico"" />
<meta name=""msapplication-task"" content=""name=BBC Travel;action-uri=http://www.bbc.com/travel?ocid=global-travel-pinned-ie9;icon-uri=http://news.bbcimg.co.uk/shared/img/bbccom/favicon_16.ico"" />
<meta name=""msapplication-task"" content=""name=BBC Weather;action-uri=http://www.bbc.co.uk/weather/?ocid=global-weather-pinned-ie9;icon-uri=http://news.bbcimg.co.uk/shared/img/bbccom/favicon_16.ico"" />

<!-- BBCCOM Server-side -->

<link href=""http://news.bbcimg.co.uk/css/screen/shared/0.3.189/3pt_ads.css"" rel=""stylesheet"" type=""text/css"" />
<script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/bbccom/0.3.189/bbccom.js""></script>
<script type=""text/javascript"">/*<![CDATA[*/
    bbcdotcom.objects('page', 'create', bbcdotcom);
    bbcdotcom.page.edition = '(none)',
    bbcdotcom.page.url = '/news/uk-23119325',
    bbcdotcom.page.zoneFile = '3pt_zone_file',
    bbcdotcom.page.http_host = 'www.bbc.co.uk'
    
/*]]>*/</script>
<script type=""text/javascript"">/*<![CDATA[*/(function(){switch(bbcdotcom.page.url){case""/"":case""/default.stm"":bbcdotcom.page.url=(bbcdotcom.page.edition===""domestic"")?""/1/hi/default.stm"":""/2/hi/default.stm"";break;case""/sport"":case""/sport/"":case""/sport/default.stm"":bbcdotcom.page.url=(bbcdotcom.page.edition===""domestic"")?""/sport1/hi/default.stm"":""/sport2/hi/default.stm"";break}if(bbcdotcom.page.bddUseLatestFromTest){BBC.adverts.setScriptRoot(""http://wwwpreview.test.newsonline.tc.nca.bbc.co.uk/js/app/bbccom/""+bbcdotcom.latest_version+""/"")}else{BBC.adverts.setScriptRoot(""http://news.bbcimg.co.uk/js/app/bbccom/0.3.189/"")}BBC.adverts.setImgRoot(""http://news.bbcimg.co.uk/shared/img/bbccom/"");BBC.adverts.init({domain:bbcdotcom.page.http_host,location:bbcdotcom.page.url,zoneVersion:bbcdotcom.page.zoneFile,zoneReferrer:document.referrer})}());if(BBC.adverts.getV6Gvl3()&&""undefined""!==typeof bbcdotcom.page.bddUseLatestFromTest){document.write(unescape('%3Cscript type=""text/javascript"" src=""http://wwwpreview.test.newsonline.tc.nca.bbc.co.uk/js/app/bbccom/'+bbcdotcom.latest_version+'/advert.js""'))}else{if(BBC.adverts.getV6Gvl3()){document.write(unescape('%3Cscript type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/bbccom/0.3.189/advert.js""%3E%3C/script%3E'))}}if(/[?|&]metadata=yes(&|$)/.test(window.location.search)){document.write(""http://www.test.bbc.com/wwscripts/metadata?bbcdotcom_asset=""+window.location.hostname+window.location.pathname)};/*]]>*/</script>

    	
        

	
	

        

<script type=""text/javascript"">
	if(typeof BBC.adverts != 'undefined' && typeof BBC.adverts.setPageVersion != 'undefined'){
		BBC.adverts.setPageVersion('(none)');
	}
</script>

    
    

        		<!-- hi/news/head_last.inc -->

<link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://news.bbcimg.co.uk/view/1_4_38/cream/hi/news/skin.css"" />


<link rel=""apple-touch-icon"" href=""http://news.bbcimg.co.uk/img/1_0_2/cream/hi/news/iphone.png""/>
<script type=""text/javascript"">
    bbcRequireMap['module/weather'] = '/inc/specials/cream/hi/news/personalisation/weather';
    bbcRequireMap['module/local'] = '/inc/specials/cream/hi/news/personalisation';
    require({ baseUrl: 'http://static.int.bbci.co.uk/', paths: bbcRequireMap, waitSeconds: 30 });
</script>
<script type=""text/javascript"">
require([""jquery-1"", ""istats-1""], function ($, istats) {
    $(function() {
        istats.track('external', {region: $('.story-body'), linkLocation : 'story-body'});
        istats.track('external', {region: $('.story-related .related-links'), linkLocation : 'related-links'});
        istats.track('external', {region: $('.story-related .newstracker-list'), linkLocation : 'newstracker'});
    });
});
</script>





	
    		
		
	
    	
   

<!-- CPS COMMENT STATUS: false -->


	   <!--Rendered by 2036006 -->
	   <link rel=""schema.dcterms"" href=""http://purl.org/dc/terms/"" />
	   <meta name=""DCTERMS.created"" content=""2013-06-30T12:37:53+00:00"" />
	   <meta name=""DCTERMS.modified"" content=""2013-06-30T12:37:53+00:00"" />
    </head>

        	    <!--[if lte IE 6]><body class=""news ie disable-wide-advert""><![endif]-->
    <!--[if IE 7]><body class=""news ie7 disable-wide-advert""><![endif]-->
    <!--[if IE 8]><body class=""news ie8 disable-wide-advert""><![endif]-->
    <!--[if !IE]>--><body class=""news disable-wide-advert""><!--<![endif]-->
	<div class=""livestats-web-bug""><img alt="""" id=""livestats"" src=""http://stats.bbc.co.uk/o.gif?~RS~s~RS~News~RS~t~RS~HighWeb_AV~RS~i~RS~23119325~RS~p~RS~99116~RS~a~RS~International~RS~u~RS~/news/uk-23119325~RS~r~RS~http://news.google.com/~RS~q~RS~~RS~z~RS~33~RS~""/></div>
        
	
    <!-- BBCDOTCOM body first include -->
    

<script type=""text/javascript"">BBC.adverts.write(""wallpaper"",false);</script>
<script type=""text/javascript"">/*<![CDATA[*/BBC.adverts.wallpaperBodyTag=document.getElementsByTagName(""body"");BBC.adverts.wallpaperATag=document.getElementsByTagName(""a"");if(""undefined""!=typeof BBC.adverts.wallpaperATag&&""undefined""!=typeof BBC.adverts.wallpaperATag[0]&&""undefined""!=typeof BBC.adverts.wallpaperBodyTag&&""undefined""!=typeof BBC.adverts.wallpaperBodyTag[0]&&-1!==BBC.adverts.wallpaperATag[0].href.indexOf(""http://ad.doubleclick.net"")){BBC.adverts.wallpaperBodyTag[0].removeChild(BBC.adverts.wallpaperATag[0])};/*]]>*/</script>


	
	

       <!-- BBCDOTCOM body first spectrum -->
     <!-- ISTATS -->



    






 <script type=""text/javascript"">/*<![CDATA[*/ bbcFlagpoles_istats = 'ON'; istatsTrackingUrl = '//sa.bbc.co.uk/bbc/bbc/s?name=news.uk.media_asset.23119325.page&cps_asset_id=23119325&page_type=media_asset&section=uk&app_version=6.2.144-RC4&first_pub=2013-06-30T12:37:53+00:00&last_editorial_update=2013-06-30T12:37:53+00:00&title=Cameron+urges+Pakistan+union+on+terror+&comments_box=false&cps_media_type=video&cps_media_state=ondemand&by_nation=&app_type=web&ml_name=SSI&ml_version=0.16.1&language=en-GB'; if (window.istats_countername) { istatsTrackingUrl = istatsTrackingUrl.replace(/([?&]name=)[^&]+/ig, '$1' + istats_countername); } (function() { if ( /\bIDENTITY=/.test(document.cookie) ) { istatsTrackingUrl += '&bbc_identity=1'; } var c = (document.cookie.match(/\bckns_policy=(\d\d\d)/)||[]).pop() || ''; istatsTrackingUrl += '&bbc_mc=' + (c? 'ad'+c.charAt(0)+'ps'+c.charAt(1)+'pf'+c.charAt(2) : 'not_set'); if ( /\bckns_policy=\d\d0/.test(document.cookie) ) { istatsTrackingUrl += '&ns_nc=1'; } var screenWidthAndHeight = 'unavailable'; if (window.screen && screen.width && screen.height) { screenWidthAndHeight = screen.width + 'x' + screen.height; } istatsTrackingUrl += ('&screen_resolution=' + screenWidthAndHeight); istatsTrackingUrl += '&blq_s=3.5&blq_r=3.5&blq_v=journalism-worldwide'; })(); /*]]>*/</script>  <!-- Begin iStats 20100118 (UX-CMC 1.1009.3) --> <script type=""text/javascript"">/*<![CDATA[*/ (function() { window.istats || (istats = {}); var cookieDisabled = (document.cookie.indexOf('NO-SA=') != -1), hasCookieLabels = (document.cookie.indexOf('sa_labels=') != -1), hasClickThrough = /^#sa-(.*?)(?:-sa(.*))?$/.test(document.location.hash), runSitestat = !cookieDisabled && !hasCookieLabels && !hasClickThrough && !istats._linkTracked; if (runSitestat && bbcFlagpoles_istats === 'ON') { sitestat(istatsTrackingUrl); } else { window.ns_pixelUrl = istatsTrackingUrl; /* used by Flash library to track */ } function sitestat(n){var j=document,f=j.location,b="""";if(j.cookie.indexOf(""st_ux="")!=-1){var k=j.cookie.split("";"");var e=""st_ux"",h=document.domain,a=""/"";if(typeof ns_!=""undefined""&&typeof ns_.ux!=""undefined""){e=ns_.ux.cName||e;h=ns_.ux.cDomain||h;a=ns_.ux.cPath||a}for(var g=0,f=k.length;g<f;g++){var m=k[g].indexOf(""st_ux="");if(m!=-1){b=""&""+unescape(k[g].substring(m+6))}}document.cookie=e+""=; expires=""+new Date(new Date().getTime()-60).toGMTString()+""; path=""+a+""; domain=""+h}ns_pixelUrl=n;n=ns_pixelUrl+""&ns__t=""+(new Date().getTime())+""&ns_c=""+((j.characterSet)?j.characterSet:j.defaultCharset)+""&ns_ti=""+escape(j.title)+b+""&ns_jspageurl=""+escape(f&&f.href?f.href:j.URL)+""&ns_referrer=""+escape(j.referrer);if(n.length>2000&&n.lastIndexOf(""&"")){n=n.substring(0,n.lastIndexOf(""&"")+1)+""ns_cut=""+n.substring(n.lastIndexOf(""&"")+1,n.lastIndexOf(""="")).substring(0,40)}(j.images)?new Image().src=n:j.write('<p><i'+'mg src=""'+n+'"" height=""1"" width=""1"" alt="""" /></p>')}; })(); /*]]>*/</script> <noscript><p style=""position: absolute; top: -999em;""><img src=""//sa.bbc.co.uk/bbc/bbc/s?name=news.uk.media_asset.23119325.page&amp;cps_asset_id=23119325&amp;page_type=media_asset&amp;section=uk&amp;app_version=6.2.144-RC4&amp;first_pub=2013-06-30T12:37:53+00:00&amp;last_editorial_update=2013-06-30T12:37:53+00:00&amp;title=Cameron+urges+Pakistan+union+on+terror+&amp;comments_box=false&amp;cps_media_type=video&amp;cps_media_state=ondemand&amp;by_nation=&amp;app_type=web&amp;ml_name=SSI&amp;ml_version=0.16.1&amp;language=en-GB&amp;blq_s=3.5&amp;blq_r=3.5&amp;blq_v=journalism-worldwide"" height=""1"" width=""1"" alt="""" /></p></noscript> <!-- End iStats (UX-CMC) -->   <div id=""blq-global""> <div id=""blq-pre-mast"" xml:lang=""en-GB""> <!-- Pre mast --> 
<!-- BBCDOTCOM leaderboard template:server-side journalismVariant: true ipIsAdvertiseCombined: true adsEnabled: false showDotcom: true flagpole: ON showAdAboveBlq: true blqLeaderboardAd: true -->
 </div> </div>  <script type=""text/html"" id=""blq-bbccookies-tmpl""><![CDATA[ <div id=""bbccookies-prompt""> <h2> Cookies on the BBC website </h2> <p> We use cookies to ensure that we give you the best experience on our website. We also use cookies to ensure we show you advertising that is relevant to you. If you continue without changing your settings, we'll assume that you are happy to receive all cookies on the BBC website. However, if you would like to, you can <a href=""/privacy/cookies/managing/cookie-settings.html"">change your cookie settings</a> at any time. </p> <ul> <li id=""bbccookies-continue""> <button type=""button"" id=""bbccookies-continue-button"">Continue</button> </li> <li id=""bbccookies-more""><a href=""/privacy/cookies/bbc"">Find out more</a></li></ul> </div> ]]></script> <script type=""text/javascript"">/*<![CDATA[*/ (function(){if(bbccookies._showPrompt()){var i=document,b=i.getElementById(""blq-pre-mast""),f=i.getElementById(""blq-global""),h=i.getElementById(""blq-container""),c=i.getElementById(""blq-bbccookies-tmpl""),a,g,e;if(b&&i.createElement){a=i.createElement(""div"");a.id=""bbccookies"";e=c.innerHTML;e=e.replace(""<""+""![CDATA["","""").replace(""]]""+"">"","""");a.innerHTML=e;if(f){f.insertBefore(a,b)}else{h.insertBefore(a,b)}g=i.getElementById(""bbccookies-continue-button"");g.onclick=function(){a.parentNode.removeChild(a);return false};bbccookies._setPolicy()}}})(); /*]]>*/</script>  <div id=""blq-masthead"" class=""blq-clearfix blq-mast-bg-transparent-light blq-lang-en-GB blq-ltr""> <span id=""blq-mast-background""><span></span></span>  <div id=""blq-mast"" class=""blq-rst"">  <div id=""blq-mast-bar"" class=""blq-masthead-container blq-journalism-worldwide""> <div id=""blq-blocks""> <a href=""http://www.bbc.co.uk/"" hreflang=""en-GB""> <abbr title=""British Broadcasting Corporation"" class=""blq-home""> <img src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/img/blq-blocks_grey_alpha.png"" alt=""BBC"" width=""84"" height=""24"" /> </abbr> </a> </div> <div id=""blq-acc-links""> <h2 id=""page-top"">Accessibility links</h2> <ul>  <li><a href=""#main-content"">Skip to content</a></li>  <li><a href=""#blq-local-nav"">Skip to local navigation</a></li>  <li><a href=""http://www.bbc.co.uk/accessibility/"">Accessibility Help</a></li> </ul> </div> <div id=""blq-sign-in"" class=""blq-gel"">  </div> <div id=""blq-nav""> <h2>bbc.co.uk navigation</h2>     <ul id=""blq-nav-main"">   <li id=""blq-nav-news""> <a href=""http://www.bbc.com/news/"">News</a> </li>    <li id=""blq-nav-sport""> <a href=""http://www.bbc.co.uk/sport/"">Sport</a> </li>    <li id=""blq-nav-weather""> <a href=""http://www.bbc.co.uk/weather/"">Weather</a> </li>    <li id=""blq-nav-capital""> <a href=""http://www.bbc.com/capital/"">Capital</a> </li>    <li id=""blq-nav-culture""> <a href=""http://www.bbc.com/culture/"">Culture</a> </li>    <li id=""blq-nav-autos""> <a href=""http://www.bbc.com/autos/"">Autos</a> </li>    <li id=""blq-nav-tv""> <a href=""http://www.bbc.co.uk/tv/"">TV</a> </li>    <li id=""blq-nav-radio""> <a href=""http://www.bbc.co.uk/radio/"">Radio</a> </li>    <li id=""blq-nav-more""> <a href=""http://www.bbc.co.uk/a-z/"">More&hellip;</a> </li>      </ul>   <div id=""blq-nav-search""> <form method=""get"" action=""http://search.bbc.co.uk/search"" accept-charset=""utf-8"" id=""blq-search-form""> <div>  <input type=""hidden"" name=""go"" value=""toolbar"" />  <input type=""hidden"" value=""http://www.bbc.co.uk/news/uk-23119325"" name=""uri"" />    <input type=""hidden"" name=""scope"" value=""news"" />  <label for=""blq-search-q"" class=""blq-hide"">Search term:</label> <input id=""blq-search-q"" type=""text"" name=""q"" value="""" maxlength=""128"" /> <button id=""blq-search-btn"" type=""submit""><span><img src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/img/blq-search_grey_alpha.png"" width=""13"" height=""13"" alt=""Search""/></span></button> </div> </form> </div>  </div> </div> </div> </div> <div id=""blq-container-outer"" class=""blq-journalism-worldwide blq-ltr"" >  <div id=""blq-container"" class=""blq-lang-en-GB blq-dotcom""> <div id=""blq-container-inner"" xml:lang=""en-GB"">   <div id=""blq-main"" class=""blq-clearfix"">   
	

                        		    	
		<div class=""uk  has-no-ticker "">
			<div id=""header-wrapper"">

			  
    		      			      				  <h2 id=""header"">
    			      	            <a rel=""index"" href=""http://www.bbc.co.uk/news/""><img alt=""BBC News"" src=""http://news.bbcimg.co.uk/img/1_0_2/cream/hi/news/news-blocks.gif"" /></a>
    	                	            	    	            		<span class=""section-title"">UK</span>
    	            	    	            		   		      				  </h2>
    			  			  
			  
			    <div class=""bbccom_advert_placeholder"">
			      <script type=""text/javascript"">$render(""advert"",""advert-sponsor-section"");</script>
			    </div>
			    <script type=""text/javascript"">$render(""advert-post-script-load"");</script>
			  
		        

			  	            <div id=""blq-local-nav"">
 	            <ul id=""nav"" class=""nav"">
                	
        	        		                	
        	            	<li class=""first-child ""><a href=""/news/"">Home</a></li>
                            	
        	        	        	
        	        		<li class=""selected""><a href=""/news/uk/"">UK</a></li>
        		        		                            	
        	        	        	
        	            	<li><a href=""/news/world/africa/"">Africa</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/asia/"">Asia</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/europe/"">Europe</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/latin_america/"">Latin America</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/middle_east/"">Mid-East</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/world/us_and_canada/"">US &amp; Canada</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/business/"">Business</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/health/"">Health</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/science_and_environment/"">Sci/Environment</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/technology/"">Tech</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/entertainment_and_arts/"">Entertainment</a></li>
                            	
        	        	        	
        	            	<li><a href=""/news/10462520"">Video</a></li>
                            </ul> 
        
	    	      <ul id=""sub-nav"" class=""nav""> 
	        	        			        	        	
	        		            	<li class=""first-child ""><a href=""/news/england/"">England</a></li>
	            	        	        		        	
	        		            	<li><a href=""/news/northern_ireland/"">Northern Ireland</a></li>
	            	        	        		        	
	        		            	<li><a href=""/news/scotland/"">Scotland</a></li>
	            	        	        		        	
	        		            	<li><a href=""/news/wales/"">Wales</a></li>
	            	        	        		        	
	        		            	<li><a href=""/news/politics/"">UK Politics</a></li>
	            	        	        		        	
	        		            	<li><a href=""/news/education/"">Education</a></li>
	            	        	      </ul> 
	    	</div>

			  
	        </div>
	        <!-- START CPS_SITE CLASS: international -->
	        <div id=""content-wrapper"" class=""international"">

					<div class=""advert"">
											</div>
                                            <div id=""bbccom_custom_branding"">
    <script type=""text/javascript"">
        /*<![CDATA[*/
        if(typeof bbcdotcom.objects('bbcdotcom.branding.init') === 'function') {
            bbcdotcom.branding.init(BBC.adverts.getZoneData().zone, BBC.adverts.getAdKeyword());
            bbcdotcom.branding.write();
        }
        /*]]>*/
    </script>
	<div class=""bbccom_advert_placeholder"">
    <script type=""text/javascript"">
        /*<![CDATA[*/
        $render(""advert"",""advert-sponsor-subsection"");
        /*]]>*/
    </script>
</div>
</div>
<script type=""text/javascript"">
        /*<![CDATA[*/
	$render(""advert-post-script-load"");
        /*]]>*/
</script>
                    
	            <!-- START CPS_SITE CLASS: media_asset -->
	            <div id=""main-content"" class=""media-asset blq-clearfix"">
			<!-- No EWA -->




    



    <div class=""layout-block-a layout-block"">
	<h1 class=""story-header"">Cameron urges Pakistan union on terror </h1>
	
    <div class=""emp"">
        <!--  Embedding the player -->
        <!--  This is the embedded player component -->


	
 



<!-- wwrights check -->
<!-- Empty country is used on test environment -->



<div class=""videoInStoryD"">
    <div id=""emp-23119325-8153"" class=""emp"">
                    
		
        <noscript>
            <div class=""warning"">
                                <img class=""holding"" src=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465131_68465130.jpg"" alt=""David Cameron in Pakistan"" />
                                <p><strong>Please turn on JavaScript.</strong> Media requires JavaScript to play.</p>
            </div>
        </noscript>
        <object width=""0"" height=""0"">
            <param name=""id"" value=""embeddedPlayer_23119325"" />
                    <param name=""width"" value=""640"" />
            <param name=""height"" value=""360"" />    
                    <param name=""size"" value=""Full"" />
					<param name=""holdingImage"" value=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465131_68465130.jpg"" />
							<param name=""externalIdentifier"" value=""p01c3qn2"" />
		            <param name=""playlist"" value=""http://playlists.bbc.co.uk/news/uk-23119325A/playlist.sxml"" />
            <param name=""config_settings_autoPlay"" value=""true"" />
            <param name=""config_settings_showPopoutButton"" value=""false"" />
            <param name=""config_plugin_fmtjLiveStats_pageType"" value=""eav1"" />
            <param name=""config_plugin_fmtjLiveStats_edition"" value=""International"" />
			
		            <param name=""fmtjDocURI"" value=""/news/uk-23119325""/>
                
            <param name=""companionId"" value=""bbccom_companion_23119325"" />
        
                    <param name=""config_settings_showShareButton"" value=""true"" />
            <param name=""config_settings_showUpdatedInFooter"" value=""true"" />
        </object>
        <!-- embedding script -->
        
        <script type=""text/javascript"">
    //<![CDATA[
        (function(){
            // create a new player, but don't write it yet
            var emp = new bbc.fmtj.av.emp.Player('emp-23119325-8153');
            // if the emps have already been loaded, we need to call the write method manually
            if(bbc.fmtj.av.emp.loaded){
                emp.setMediator('href', '{protocol}://{host}/mediaselector/5/select/version/2.0/mediaset/{mediaset}/vpid/{id}');
                emp.write();
            }
        })();
    //]]>
</script>
            </div>
            <!-- companion banner --> 
          
		
			<div class=""bbccom_advert_placeholder"">
				<script type=""text/javascript"">$render(""advert"",""advert-companion"",""23119325"");</script>
			</div>
			<script type=""text/javascript"">$render(""advert-post-script-load"");</script>
		
         
        <!-- END - companion banner --> 
    	
        
		

</div>
<!-- end of the embedded player component -->

        <!-- Player embedded -->
	<span class=""story-date""> 
	   <span class=""date"">30 June 2013</span>
<span class=""time-text"">Last updated at </span><span class=""time"">12:37 GMT</span>
	  
    </span>
	<a class=""emp-help"" href=""/news/help-21352667"" title=""help"">Help</a>	
    </div>
	
	 <div class=""emp-decription"" id=""meta-information"">
						
              <p>David Cameron says that Britain will &quot;stand together&quot; with Pakistan in the fight against terrorism, following talks with Pakistan&#039;s newly-elected prime minister Nawaz Sharif.</p>
        <p>Mr Cameron urged Pakistan to help to create a &quot;stable&quot; and &quot;democratic&quot; Afghanistan. </p>
        <p>The British prime minister is on a two-day official visit to Pakistan, where Mr Sharif was recently re-elected for an unprecedented third time. </p>
        <p>The BBC&#039;s Carole Walker is travelling with Mr Cameron.</p>
  
		
	</div>
	
		
    	<!-- Read More - See Also -->
			    <div class=""read-more"">
        <h2>Read More</h2>
        <ul>				
           			 
            									
									<li class=""column-1  first-child"">
                <h3><a href=""http://www.bbc.co.uk/news/uk-23116681"">UK and Pakistan to &#039;stand together&#039;</a></h3>
            </li>
                    </ul>
    </div>
       		
<div id=""page-bookmark-links-foot"" class=""share-help"">
  <h3>Share this page</h3>
  <ul>  	
    <li class=""delicious"">
      <a title=""Post this story to Delicious"" href=""http://del.icio.us/post?url=http://www.bbc.co.uk/news/uk-23119325&amp;title=BBC+News+-+Cameron+urges+Pakistan+union+on+terror+"">Delicious</a>
    </li>
    <li class=""digg"">
      <a title=""Post this story to Digg"" href=""http://digg.com/submit?url=http://www.bbc.co.uk/news/uk-23119325&amp;title=BBC+News+-+Cameron+urges+Pakistan+union+on+terror+"">Digg</a>
    </li>
    <li class=""facebook"">
      <a title=""Post this story to Facebook"" href=""http://www.facebook.com/sharer.php?u=http://www.bbc.co.uk/news/uk-23119325&amp;t=BBC+News+-+Cameron+urges+Pakistan+union+on+terror+"">Facebook</a>
    </li>
    <li class=""reddit"">
      <a title=""Post this story to reddit"" href=""http://reddit.com/submit?url=http://www.bbc.co.uk/news/uk-23119325&amp;title=BBC+News+-+Cameron+urges+Pakistan+union+on+terror+"">reddit</a>
    </li>
    <li class=""stumbleupon"">
      <a title=""Post this story to StumbleUpon"" href=""http://www.stumbleupon.com/submit?url=http://www.bbc.co.uk/news/uk-23119325&amp;title=BBC+News+-+Cameron+urges+Pakistan+union+on+terror+"">StumbleUpon</a>
    </li>
    <li class=""twitter"">
      <a title=""Post this story to Twitter"" href=""http://twitter.com/home?status=BBC+News+-+Cameron+urges+Pakistan+union+on+terror++http://www.bbc.co.uk/news/uk-23119325"">Twitter</a>
    </li>
    <li class=""email"">
      <a title=""Email this story"" href=""http://newsvote.bbc.co.uk/mpapps/pagetools/email/www.bbc.co.uk/news/uk-23119325"">Email</a>
    </li>
    <li class=""print"">
      <a title=""Print this story"" href=""?print=true"">Print</a>
    </li>
  </ul>
<!--  Social media icons by Paul Annet | http://nicepaul.com/icons  -->

<div class=""bbccom_advert_placeholder"">
	<script type=""text/javascript"">$render(""advert"",""advert-sponsor-module"",""page-bookmark-links"");</script>
</div>
<script type=""text/javascript"">$render(""advert-post-script-load"");</script>
  
</div>
<script type=""text/javascript""> 
<!--
$render(""page-bookmark-links"",""page-bookmark-links-foot"",{
    useForgeShareTools:""true"",
    position:""bottom"",
    site:'News', 
    headline:'BBC News - Cameron urges Pakistan union on terror ', 
    storyId:'23119325', 
    sectionId:'99116', 
    url:'http://www.bbc.co.uk/news/uk-23119325', 
    edition:'International'
}); 
-->
</script>

    <!-- end Read Mode - See Also -->
    
</div>
<!-- / layout-block-a --> 
<div class=""layout-block-b layout-block"">
	<div id=""most-watched"" class=""livestats most-watched-list"">
<h2>Most watched/listened</h2>
  <ol>
		     <li
  class=""first-child ol1"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/2/hi/uk_news/8705438.stm""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Carol's saucy slip of the tongue!<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/49081000/jpg/_49081679_carol.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol2"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/video_and_audio/""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>One-minute World News<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/55182000/gif/_55182136__48351578_640x360-world-news-1.gif"" /></a>
  </h3>
</li>
<li
  class=""ol3"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-23116468""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Global Gay Pride: Parades in cities <img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68461000/jpg/_68461556_pridee.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol4"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/entertainment-arts-23116750""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>'It was the swagger of Mick Jagger'<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68461000/jpg/_68461866_68461766.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol5"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-latin-america-23098260""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Drag queens brawl over winner mix up<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68432000/jpg/_68432445_68432405.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol6"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-middle-east-23116465""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Crowds fill Tahrir Square<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68461000/jpg/_68461411_68461092.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol7"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-middle-east-23116749""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Egypt demo to mark Morsi anniversary<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68463000/jpg/_68463823_68462224.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol8"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-latin-america-23109817""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Football fans throw chairs at president<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68455000/jpg/_68455348_68452031.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol9"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/entertainment-arts-11242699""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Alexandra Burke on the X Factor<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/49037000/jpg/_49037503_burke81.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol10"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-us-canada-23116826""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Triple-digit heat wave grips US west<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68462000/jpg/_68462107_68462096.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol11"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/uk-23118435""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Police appeal over murder suspect<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465116_68463663.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol12"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-middle-east-23109950""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>US warns against travel to Egypt <img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68452000/jpg/_68452681_68452592.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol13"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/entertainment-arts-23117382""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>How street cat named Bob saved busker<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68462000/jpg/_68462757_bob.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol14"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/world-europe-23106999""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Violence erupts at Egypt protests<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68449000/jpg/_68449567_68448818.jpg"" /></a>
  </h3>
</li>
<li
  class=""ol15"">
  <h3>
    <a
      href=""http://www.bbc.co.uk/news/business-23062272""
      class=""play""><span class=""livestats-icon""></span><span
        class=""gvl3-icon-wrapper""><span
          class=""gvl3-icon gvl3-icon-invert-watch"">Play </span></span>Microsoft unveils new Windows 8<img
        alt=""""
        src=""http://news.bbcimg.co.uk/media/images/68384000/jpg/_68384204_68384113.jpg"" /></a>
  </h3>
</li>
		</ol>
</div>
<script type=""text/javascript"">$render(""most-watched"",""most-watched"");</script>
    <div class=""advert"">
   	
	<div class=""bbccom_advert_placeholder"">
   		<script type=""text/javascript"">$render(""advert"",""advert-mpu"");</script>
	</div>
	<script type=""text/javascript"">$render(""advert-post-script-load"");</script>
		
    </div>
</div>
<!-- / layout-block-b --> 
<div class=""layout-block-c"">

  
<!-- AV content promotional Module Include path -->	






		     <div class=""hyperpuff"">
	       	                                 
<div class=""hyper-container-title"">
        
<div id=""group-1"" class=""playlist"">
  	  <h2>World
	  </h2>
	
  	
	<ul>
				
    								        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-us-canada-23116826"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Triple-digit heat wave grips US west
            					<img src=""http://news.bbcimg.co.uk/media/images/68462000/jpg/_68462107_68462096.jpg"" alt=""Elephants at Utahs Hogle Zoo are cooled off with a water hose"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-middle-east-23115884"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Air strikes shake Syria&#039;s Homs
            					<img src=""http://news.bbcimg.co.uk/media/images/68463000/jpg/_68463900_68463891.jpg"" alt=""Still from unverified amateur footage purportedly shows man taking cover in alleyway as shells hit Homs"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-us-canada-23116820"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Motorhomes: An American love affair
            					<img src=""http://news.bbcimg.co.uk/media/images/68462000/jpg/_68462186_68462183.jpg"" alt=""Couple at US Airstream rally"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-middle-east-23116465"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Egypt protesters send message to Morsi
            					<img src=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465937_68461092.jpg"" alt=""Egyptian opposition supporters gather for a demonstration  in Cairo&#039;s landmark Tahrir Square "" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-23116468"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Global Gay Pride: View from parades
            					<img src=""http://news.bbcimg.co.uk/media/images/68461000/jpg/_68461556_pridee.jpg"" alt=""Gay Pride parade in Mexico"" />
        					</a>
        				</h3>
        			</li>
    				
        													</ul>
</div>



<script type=""text/javascript"">$render(""av-content-promotion"",""av-content-promotion"");</script>

      
<div id=""group-2"" class=""playlist"">
  	  <h2>Business
	  </h2>
	
  	
	<ul>
				
    								        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/business-23116753"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Cost of using mobile abroad to drop
            					<img src=""http://news.bbcimg.co.uk/media/images/68462000/jpg/_68462279_68461670.jpg"" alt=""Blackberry mobile phone"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/business-23094806"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								EU to tackle youth unemployment
            					<img src=""http://news.bbcimg.co.uk/media/images/68429000/jpg/_68429387_68428356.jpg"" alt=""People queue at unemployment office"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/business-23095692"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Selling skateboarding to the masses
            					<img src=""http://news.bbcimg.co.uk/media/images/68460000/jpg/_68460015_68460006.jpg"" alt=""Niece of Dubai&#039;s leader on skateboard"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/business-23095697"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Blackberry investors &#039;not impressed&#039;
            					<img src=""http://news.bbcimg.co.uk/media/images/68440000/jpg/_68440730_68440308.jpg"" alt=""Blackberry handset"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/business-23093989"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								&#039;Financial rock star&#039; ready for BoE
            					<img src=""http://news.bbcimg.co.uk/media/images/68427000/jpg/_68427332_68427292.jpg"" alt=""Mark Carney"" />
        					</a>
        				</h3>
        			</li>
    				
        													</ul>
</div>



<script type=""text/javascript"">$render(""av-content-promotion"",""av-content-promotion"");</script>

      
<div id=""group-3"" class=""playlist"">
  	  <h2>Science &amp; Technology
	  </h2>
	
  	
	<ul>
				
    								        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-us-canada-23116467"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								&#039;Temperatures are breaking records&#039;
            					<img src=""http://news.bbcimg.co.uk/media/images/68461000/jpg/_68461946_68461267.jpg"" alt=""Sign warns in Death Valley National Park in California"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-england-23048394"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								St Cuthbert: Father of conservation
            					<img src=""http://news.bbcimg.co.uk/media/images/68391000/jpg/_68391336_gospel08.jpg"" alt=""Puffin graphic"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/technology-23117095"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Inside RoboCup 2013 in Holland
            					<img src=""http://news.bbcimg.co.uk/media/images/68463000/jpg/_68463969_68463625.jpg"" alt=""The Dutch robot-football team Tech United"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/business-23062272"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Microsoft unveils new Windows 8
            					<img src=""http://news.bbcimg.co.uk/media/images/68384000/jpg/_68384204_68384113.jpg"" alt=""Windows 8"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-asia-23076297"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Talking &#039;robot astronaut&#039; set for ISS
            					<img src=""http://news.bbcimg.co.uk/media/images/68404000/jpg/_68404218_robot.jpg"" alt=""Kirobo, a Japanese &#039;&#039;robot astronaut&#039;&#039;"" />
        					</a>
        				</h3>
        			</li>
    				
        													</ul>
</div>



<script type=""text/javascript"">$render(""av-content-promotion"",""av-content-promotion"");</script>

      
<div id=""group-4"" class=""playlist"">
  	  <h2>Entertainment
	  </h2>
	
  	
	<ul>
				
    								        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-england-22970512"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Meet the modern St Cuthbert
            					<img src=""http://news.bbcimg.co.uk/media/images/68397000/jpg/_68397528_stcuthbert_statue2.jpg"" alt=""St Cuthbert statue"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/entertainment-arts-23117382"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								How street cat named Bob saved busker
            					<img src=""http://news.bbcimg.co.uk/media/images/68462000/jpg/_68462757_bob.jpg"" alt=""Bob the Cat on The Andrew Marr Show"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/entertainment-arts-23116750"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Glasto witnesses &#039;swagger of Jagger&#039;
            					<img src=""http://news.bbcimg.co.uk/media/images/68461000/jpg/_68461866_68461766.jpg"" alt=""Sir Mick Jagger and Keith Richards of The Rolling Stones perform on the Pyramid Stage"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/entertainment-arts-23112996"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Behind the scenes: Pyramid Stage
            					<img src=""http://news.bbcimg.co.uk/media/images/68456000/jpg/_68456398_68455731.jpg"" alt=""Backstage at Glastonbury"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""http://www.bbc.com/culture/story/20130621-going-underground"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Modern art on London Underground
            					<img src=""http://news.bbcimg.co.uk/media/images/68442000/jpg/_68442050_tfl_976.jpg"" alt=""A poster advertising the London Underground"" />
        					</a>
        				</h3>
        			</li>
    				
        													</ul>
</div>



<script type=""text/javascript"">$render(""av-content-promotion"",""av-content-promotion"");</script>

      
<div id=""group-5"" class=""playlist"">
  	  <h2>UK
	  </h2>
	
  	
	<ul>
				
    								        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-23118435"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Police appeal over murder suspect
            					<img src=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465116_68463663.jpg"" alt=""Linzi Ashton murder scene"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-23110968"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Armed Forces Day: Red Arrows fly past
            					<img src=""http://news.bbcimg.co.uk/media/images/68454000/jpg/_68454880_68454877.jpg"" alt=""Red Arrows perform over Nottinhgam"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-23119325"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Cameron urges Pakistan union on terror 
            					<img src=""http://news.bbcimg.co.uk/media/images/68465000/jpg/_68465211_68465130.jpg"" alt=""David Cameron in Pakistan"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-23109438"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Day in life of Helmand patrol base 2
            					<img src=""http://news.bbcimg.co.uk/media/images/68451000/jpg/_68451538_afghanistansolider.jpg"" alt=""Major Aaron West, 4th Battalion the Rifles, in Afghanistan"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/uk-23109543"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-listen""> Listen</span>
      														    </span>
								UK &#039;may face energy problems&#039; 
            					<img src=""http://news.bbcimg.co.uk/media/images/68452000/jpg/_68452407_68452377.jpg"" alt=""Electricity pylons"" />
        					</a>
        				</h3>
        			</li>
    				
        													</ul>
</div>



<script type=""text/javascript"">$render(""av-content-promotion"",""av-content-promotion"");</script>

      
<div id=""group-6"" class=""playlist"">
  	  <h2>US &amp; Canada
	  </h2>
	
  	
	<ul>
				
    								        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-africa-23114667"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Charmer Obama wins over audience
            					<img src=""http://news.bbcimg.co.uk/media/images/68457000/jpg/_68457653_68458310.jpg"" alt=""U.S. President Barack Obama greets the public as he arrives to deliver remarks and takes questions at a town hall meeting with young African leaders at the University of Johannesburg Soweto campus Saturday June 29"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-africa-23113185"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Warning shots fired at anti-Obama demo
            					<img src=""http://news.bbcimg.co.uk/media/images/68459000/jpg/_68459658_68459497.jpg"" alt=""A police officer holding a gun at an anti-US demonstration in Soweto"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-us-canada-23109031"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								California gay marriage ban lifted
            					<img src=""http://news.bbcimg.co.uk/media/images/68456000/jpg/_68456528_68456525.jpg"" alt=""Sandy Stier and Kris Perry exchange rings"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-us-canada-23093393"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-watch""> Watch</span>
      														    </span>
								Ecuador defiant over Snowden
            					<img src=""http://news.bbcimg.co.uk/media/images/68427000/jpg/_68427122_ecuad.jpg"" alt="" President Rafael Correa of Ecuador"" />
        					</a>
        				</h3>
        			</li>
    				
        																			        			<li class=""ol1"">
        				<h3>
        					<a href=""/news/world-africa-23085571"" class=""play"">
							    <span class=""gvl3-icon-wrapper"">
      							      								<span class=""gvl3-icon gvl3-icon-invert-listen""> Listen</span>
      														    </span>
								The hunt for stolen Mandela painting
            					<img src=""http://news.bbcimg.co.uk/media/images/68414000/png/_68414637_mandelamccreedy.png"" alt=""McCreedy&#039;s blue Mandela painting"" />
        					</a>
        				</h3>
        			</li>
    				
        													</ul>
</div>



<script type=""text/javascript"">$render(""av-content-promotion"",""av-content-promotion"");</script>

  </div>

	       	     </div>
	

			
        
                    <!-- WORLD SECTIONS -->
                
    
    
</div>
<!-- / layout-block-c -->



	<!-- END #MAIN-CONTENT & CPS_ASSET_TYPE CLASS: media_asset -->
	</div>
<!-- END CPS_AUDIENCE CLASS: international -->
	
</div> 
<div id=""related-services"" class=""footer"">
   <div id=""news-services"">
      <h2>Services</h2>
      <ul>
         <li id=""service-mobile"" class=""first-child""><a href=""http://www.bbc.co.uk/news/10628994""><span class=""gvl3-mobile-icon-large services-icon"">&nbsp;</span>Mobile</a></li>
         <li id=""service-feeds""><a href=""/news/help-17655000""><span class=""gvl3-connected-tv-icon-large services-icon"">&nbsp;</span>Connected TV</a></li>
         <li id=""service-podcast""><a href=""http://www.bbc.co.uk/news/10628494""><span class=""gvl3-feeds-icon-large services-icon"">&nbsp;</span>News feeds</a></li>
         <li id=""service-alerts""><a href=""http://www.bbc.co.uk/news/10628323""><span class=""gvl3-alerts-icon-large services-icon"">&nbsp;</span>Alerts</a></li>
         <li id=""service-email-news""><a href=""http://www.bbc.co.uk/news/help/16617948""><span class=""gvl3-email-icon-large services-icon"">&nbsp;</span>E-mail news</a></li>
      </ul>	 
   </div>
   <div id=""news-related-sites"">
      <h2><a href=""http://www.bbc.co.uk/news/19888761"">About BBC News</a></h2>
      <ul>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/news/blogs/the_editors/"">Editors' blog</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/journalism/"">BBC College of Journalism</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/news/10621655"">News sources</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/mediaaction/"">Media Action</a></li>
         <li class=""column-1""><a href=""http://www.bbc.co.uk/editorialguidelines/"">Editorial Guidelines</a></li>
      </ul>
   </div>
</div>
</div><!-- close uk -->



	
	

   </div>   <!--[if IE 6]> <div id=""blq-ie6-upgrade""> <p> <span>You're using the Internet Explorer 6 browser to view the BBC website. Our site will work much better if you change to a more modern browser. It's free, quick and easy.</span> <a href=""http://www.browserchoice.eu/"">Find out more <span>about upgrading your browser</span> here&hellip;</a> </p> </div> <![endif]-->  <div id=""blq-foot"" xml:lang=""en-GB"" class=""blq-rst blq-clearfix blq-foot-transparent blq-foot-text-dark""> <div id=""blq-footlinks""> <h2 class=""blq-hide"">BBC links</h2>       <ul>                    <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""/news/mobile/"" id=""blq-footer-mobile"">Mobile site</a></li><li><a href=""http://www.bbc.co.uk/terms/"">Terms of Use</a></li><li><a href=""http://www.bbc.co.uk/aboutthebbc/"">About the BBC</a></li> </ul> </li>                     <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""http://advertising.bbcworldwide.com"">Advertise With Us</a></li><li><a href=""http://www.bbc.co.uk/privacy/"">Privacy</a></li><li><a href=""http://www.bbc.co.uk/accessibility/"">Accessibility Help</a></li> </ul> </li>                     <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""http://www.bbc.co.uk/bbc.com/ad-choices/"">Ad Choices</a></li><li><a href=""http://www.bbc.co.uk/privacy/bbc-cookies-policy.shtml"">Cookies</a></li><li><a href=""http://www.bbc.co.uk/news/21323537"">Contact the BBC</a></li> </ul> </li>           <li class=""blq-footlinks-row""> <ul class=""blq-footlinks-row-list""> <li><a href=""http://www.bbc.co.uk/guidance/"">Parental Guidance</a></li> </ul> </li>             </ul> <script type=""text/javascript"">/*<![CDATA[*/ (function() { var mLink = document.getElementById('blq-footer-mobile'), stick = function() { var d = new Date (); d.setYear(d.getFullYear() + 1); d = d.toUTCString(); window.bbccookies.set('ckps_d=m;domain=.bbc.co.uk;path=/;expires=' + d ); window.bbccookies.set('ckps_d=m;domain=.bbc.com;path=/;expires=' + d ); }; if (mLink) {  if (mLink.addEventListener) { mLink.addEventListener('click', stick, false); } else if (mLink.attachEvent) { mLink.attachEvent('onclick', stick); } } })(); /*]]>*/</script>  </div>  <div id=""blq-foot-blocks"" class=""blq-footer-image-dark""><img src=""http://static.bbci.co.uk/frameworks/barlesque/2.48.3/desktop/3.5/img/blocks/dark.png"" width=""84"" height=""24"" alt=""BBC"" /></div>  <p id=""blq-disclaim""><span id=""blq-copy"">BBC &copy; 2013</span> <a href=""http://www.bbc.co.uk/help/web/links/"">The BBC is not responsible for the content of external sites. Read more.</a></p> <div id=""blq-obit""><p><strong>This page is best viewed in an up-to-date web browser with style sheets (CSS) enabled. While you will be able to view the content of this page in your current browser, you will not be able to get the full visual experience. Please consider upgrading your browser software or enabling style sheets (CSS) if you are able to do so.</strong></p></div> </div> </div> 
<!-- BBCDOTCOM analytics template:server-side journalismVariant: true ipIsAdvertiseCombined: true adsEnabled: false showDotcom: true flagpole: ON -->
            
    <!-- BBCCOM analytics server-side -->
<div id=""bbccomWebBug"" class=""bbccomWebBug""></div>

<script type=""text/javascript"">
    /*<![CDATA[*/
    if('undefined' != typeof(bbcdotcom) && 'undefined' != typeof(bbcdotcom.stats)) {
        bbcdotcom.stats.adEnabled = ""yes"";
        bbcdotcom.stats.contentType = ""HTML"";
    }
    /*]]>*/
</script>



    <!-- Start Audience Science -->
    <script type=""text/javascript"" src=""http://js.revsci.net/gateway/gw.js?csid=J08781""></script>
    <script type=""text/javascript"">
        /*<![CDATA[*/
        var adKeyword = document.getElementsByName('ad_keyword');
        if('/news/uk-11767495' == window.location.pathname) {
            J08781.DM_addEncToLoc(""Section"",""Royal Wedding"");
        } else if (undefined != adKeyword[0]) {
            J08781.DM_addEncToLoc(""Section"",adKeyword[0].content);
        } else if (""undefined"" != typeof bbc &&
            ""undefined"" != typeof bbc.fmtj &&
            ""undefined"" != typeof bbc.fmtj.page &&
            ""undefined"" != typeof bbc.fmtj.page.section) {
                J08781.DM_addEncToLoc(""Section"", bbc.fmtj.page.section);
        }
        J08781.DM_tag();
        /*]]>*/
    </script>
    <!-- End Audience Science -->

    <!-- SiteCatalyst code version: H.21.
    Copyright 1996-2010 Adobe, Inc. All Rights Reserved
    More info available at http://www.omniture.com -->
    
        <script type=""text/javascript"">
            var s_account = ""bbcwglobalprod"";
        </script>
    
    
        <script type=""text/javascript"" src=""http://news.bbcimg.co.uk/js/app/bbccom/0.3.189/s_code.js""></script>
    
    <script type=""text/javascript""><!--
        /************* DO NOT ALTER ANYTHING BELOW THIS LINE ! **************/
        var s_code=scw.t();if(s_code)document.write(s_code)//--></script>
        <script type=""text/javascript""><!--
        if(navigator.appVersion.indexOf('MSIE')>=0)document.write(unescape('%3C')+'\!-'+'-')
        //--></script><noscript><div><a href=""http://www.omniture.com"" title=""Web Analytics""><img
        src=""http://sa.bbc.com/b/ss/bbcwglobalprod/1/H.21--NS/0""
        height=""1"" width=""1"" alt="""" /></a></div></noscript><!--/DO NOT REMOVE/-->
    <!-- End SiteCatalyst code version: H.21. -->


    <!-- Begin comScore Tag -->
    <script type=""text/javascript"">
        document.write(unescape(""%3Cscript src='"" + (document.location.protocol == ""https:"" ? ""https://sb"" : ""http://b"") + "".scorecardresearch.com/beacon.js' %3E%3C/script%3E""));</script>
    <script type=""text/javascript"">
        COMSCORE.beacon({
            c1:2,
            c2:""6035051"",
            c3:"""",
            c4:""www.bbc.co.uk/news/uk-23119325"",
            c5:"""",
            c6:"""",
            c15:""""
        });
    </script>
    <noscript>
        <div>
            <img src=""http://b.scorecardresearch.com/b?c1=2&amp;c2=6035051&amp;c3=&amp;c4=www.bbc.co.uk/news/uk-23119325&amp;c5=&amp;c6=&amp;c15=&amp;cv=1.3&amp;cj=1"" style=""display:none"" width=""0"" height=""0"" alt="""" />
        </div>
    </noscript>
    <!-- End comScore Tag -->








    <!-- START Nielsen Online SiteCensus V6.0 -->
    <!-- COPYRIGHT 2009 Nielsen Online -->
    <script type=""text/javascript"" src=""http://secure-au.imrworldwide.com/v60.js"">
    </script>
    <script type=""text/javascript"">
        nol_t({cid:""au-bbc"",content:""0"",server:""secure-au""}).record().post();
    </script>
    <noscript>
        <div>
            <img src=""http://secure-au.imrworldwide.com/cgi-bin/m?ci=au-bbc&amp;cg=0&amp;cc=1&amp;ts=noscript"" alt="""" />
        </div>
    </noscript>
    <!-- END Nielsen Online SiteCensus V6.0 -->













    <!-- Effective Measure BBCCOM-1195 -->
    <script type=""text/javascript"">
      (function() {
        var em = document.createElement('script'); em.type = 'text/javascript'; em.async = true;
        em.src = ('https:' == document.location.protocol ? 'https://me-ssl' : 'http://me-cdn') + '.effectivemeasure.net/em.js';
        var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(em, s);
      })();
    </script>
    <noscript>
        <div>
            <img src=""http://me.effectivemeasure.net/em_image"" alt="""" style=""position:absolute; left:-5px;"" />
        </div>
    </noscript>
    <!-- End Effective Measure -->






     </div> </div>  <script type=""text/javascript""> if (typeof require !== 'undefined') { require(['istats-1'], function(istats){ istats.track('external', { region: document.getElementById('blq-main') }); istats.track('download', { region: document.getElementById('blq-main') }); }); } </script>  <script type=""text/html"" id=""blq-panel-template-promo""><![CDATA[ <div id=""blq-panel-promo"" class=""blq-masthead-container""></div> ]]></script> <script type=""text/html"" id=""blq-panel-template-more""><![CDATA[ <div id=""blq-panel-more"" class=""blq-masthead-container  blq-clearfix"" xml:lang=""en-GB"" dir=""ltr""> <div class=""blq-panel-container panel-paneltype-more""> <div class=""panel-header""> <h2> <a href=""http://www.bbc.co.uk/a-z/"">  More&hellip;  </a> </h2>  <a href=""http://www.bbc.co.uk/a-z/"" class=""panel-header-links panel-header-link"">Full A-Z<span class=""blq-hide""> of BBC sites</span></a>  </div> <div class=""panel-component panel-links"">       <ul>   <li> <a href=""http://www.bbc.co.uk/cbbc/""  >CBBC</a> </li>    <li> <a href=""http://www.bbc.co.uk/cbeebies/""  >CBeebies</a> </li>    <li> <a href=""http://www.bbc.co.uk/comedy/""  >Comedy</a> </li>   </ul>  <ul>   <li> <a href=""http://www.bbc.co.uk/food/""  >Food</a> </li>    <li> <a href=""http://www.bbc.co.uk/history/""  >History</a> </li>    <li> <a href=""http://www.bbc.co.uk/learning/""  >Learning</a> </li>   </ul>  <ul>   <li> <a href=""http://www.bbc.co.uk/music/""  >Music</a> </li>    <li> <a href=""http://www.bbc.co.uk/science/""  >Science</a> </li>    <li> <a href=""http://www.bbc.co.uk/nature/""  >Nature</a> </li>   </ul>  <ul>   <li> <a href=""http://www.bbc.co.uk/local/""  >Local</a> </li>    <li> <a href=""http://www.bbc.co.uk/travelnews/""  >Travel News</a> </li>   </ul>   </div> </div> ]]></script>            
	

<!-- shared/foot -->
<script type=""text/javascript"">
	bbc.fmtj.common.removeNoScript({});
	bbc.fmtj.common.tabs.createTabs({});
</script>
<!-- hi/news/foot.inc -->
<!-- shared/foot_media_asset -->
<!-- #CREAM hi news international foot.inc -->

 

</body>
</html>

";
            }
        }
    }
}
