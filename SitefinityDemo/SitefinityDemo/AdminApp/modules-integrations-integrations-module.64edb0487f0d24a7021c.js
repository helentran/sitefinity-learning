/*! For license information please see modules-integrations-integrations-module.64edb0487f0d24a7021c.js.LICENSE.txt */
(window.webpackJsonp=window.webpackJsonp||[]).push([["modules-integrations-integrations-module"],{2558:function(t,e,n){"use strict";n.r(e),n.d(e,"IntegrationsModule",(function(){return v}));var o,r,i=n(260),a=n(246),s=n(262),u=n(1810),p=n(2559),c=n(1794),l=n(1656),d=n(1202),T=n(1594),f=n(1658),R=n(1601),E=n(1603),S=n(1536),I=n(1583),m=n(2560),_=n(229),y=[{path:a.stringConstants.EMPTY_STRING,component:T.NotFoundComponent},{path:":"+s.ROUTE_PARAMS.TYPE_NAME_SEGMENT,component:c.DynamicItemRouterComponent,resolve:(o={},o[""+s.RESOLVE_NAMES.entityData]=m.IntegrationsResolver,o.metaStore=R.MetadataStoreResolver,o.siteDataStore=E.SiteDataStoreResolver,o),canActivate:[u.ContentTypeGuard],children:[{path:a.stringConstants.EMPTY_STRING,component:l.ListIndexComponent,resolve:{siteTitle:S.SiteTitleDynamicResolver}},{path:"confirm/:name",component:d.ModalWindowComponent,outlet:"dialog"}]},{path:":"+s.ROUTE_PARAMS.TYPE_NAME_SEGMENT+"/:"+s.ROUTE_PARAMS.ITEM_ID+"/:"+s.ROUTE_PARAMS.OPERATION_NAME_SEGMENT,component:c.DynamicItemRouterComponent,resolve:(r={},r[""+s.RESOLVE_NAMES.entityData]=m.IntegrationsResolver,r),canActivate:[u.ContentTypeGuard],children:[{path:a.stringConstants.EMPTY_STRING,component:l.ListIndexComponent,resolve:{siteTitle:S.SiteTitleDynamicResolver}},{path:"confirm/:name",component:d.ModalWindowComponent,outlet:"dialog"}]}],v=function(){function t(){}return t.ɵfac=function(e){return new(e||t)},t.ɵmod=_["ɵɵdefineNgModule"]({type:t}),t.ɵinj=_["ɵɵdefineInjector"]({providers:[m.IntegrationsResolver,f.ListIndexContractProvider,p.SEARCH_NOTIFICATION_BUILDER],imports:[[i.RouterModule.forChild(y),I.SharedModule],i.RouterModule]}),t}();_["ɵɵsetNgModuleScope"](v,{imports:[i.RouterModule,I.SharedModule],exports:[i.RouterModule]})},2559:function(t,e,n){"use strict";n.r(e),n.d(e,"SearchTaskNotificationBuilder",(function(){return p})),n.d(e,"SEARCH_NOTIFICATION_BUILDER",(function(){return c}));var o=n(259),r=n(1670),i=n(246),a=n(1224),s=n(1225),u=n(1669),p=function(t){function e(){var e=null!==t&&t.apply(this,arguments)||this;return e.supportedTaskTypes=[a.BackgroundTaskType.Reindex],e}return Object(o.__extends)(e,t),Object.defineProperty(e.prototype,"isDefault",{get:function(){return!1},enumerable:!1,configurable:!0}),e.prototype.isTaskSupported=function(t){return this.supportedTaskTypes.indexOf(t)>-1},e.prototype.processTask=function(e){e.TaskName===a.BackgroundTaskType.Reindex&&(e.StatusMessage?e.Description=e.StatusMessage+" for "+e.Title:e.Description="Indexing "+e.Title+"..."),t.prototype.processTask.call(this,e)},e.prototype.filterTasksCallback=function(t,e){var n,o;if(!e)return!1;var r=this.parseTaskData(t);if(e.hasOwnProperty(u.FILTERCALLBACK_PROPERTY_MAP.CURRENT_SITE_ID)){var i=e[u.FILTERCALLBACK_PROPERTY_MAP.CURRENT_SITE_ID];if((null===(n=r.siteIds)||void 0===n?void 0:n.length)>0)return(null===(o=r.siteIds)||void 0===o?void 0:o.indexOf(i))>=0}return!0},e.prototype.parseTaskData=function(t){return s.SearchBackgroundTaskDataParser.parse(t)},e.prototype.buildButtons=function(t){return[]},e.prototype.buildNotification=function(t){return this.isTaskSupported(t.TaskName)?a.TaskStatus[t.Status.toString()]===a.TaskStatus.Failed?t.StatusMessage:null:i.stringConstants.EMPTY_STRING},e}(r.DefaultTaskNotificationBuilder),c={multi:!0,provide:r.BACKGROUND_TASK_NOTIFICATION_BUILDER_TOKEN,useClass:p}},2560:function(t,e,n){"use strict";n.r(e),n.d(e,"IntegrationsResolver",(function(){return p}));var o=n(259),r=(n(260),n(131)),i=n(1150),a=n(1152),s=n(267),u=n(229),p=function(t){function e(e,n){var o=t.call(this,n)||this;return o.metadataStore=e,o}return Object(o.__extends)(e,t),e.prototype.resolve=function(t,e){return this.getEntityData(t)},e.prototype.getEntitySet=function(t){return i.DynamicItemStrategyBase.getSet(t)},e.prototype.getEntityData=function(t){var e=this;return this.metadataStore.initialize().pipe(Object(r.map)((function(n){return e.resolveEntityData(t,n,null,null)})))},e.ɵfac=function(t){return new(t||e)(u["ɵɵinject"](s.MetadataStore),u["ɵɵinject"](a.EntityDataResolver))},e.ɵprov=u["ɵɵdefineInjectable"]({token:e,factory:e.ɵfac}),e}(a.CompositeEntityDataResolver)}}]);