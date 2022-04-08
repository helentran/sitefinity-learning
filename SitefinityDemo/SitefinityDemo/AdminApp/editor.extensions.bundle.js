(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["editor.extensions.bundle1000"],{

/***/ "ext_mod_id_1649152171063":
/*!***********************************!*\
  !*** ./src/__extensions_index.ts ***!
  \***********************************/
/*! no exports provided */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _editor_extender__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./editor-extender */ "ext_mod_id_1649152171063_2");
// import { GridExtenderModule } from "./grid-extender";
// import { CustomFieldsModule } from "./custom-fields";
// import { CommandsExtenderModule } from "./commands-extender";

// sitefinityExtensionsStore.addExtensionModule(GridExtenderModule);
// sitefinityExtensionsStore.addExtensionModule(CustomFieldsModule);
// sitefinityExtensionsStore.addExtensionModule(CommandsExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_editor_extender__WEBPACK_IMPORTED_MODULE_0__["EditorExtenderModule"]);
// sitefinityExtensionsStore.addExtensionModule(ItemExtenderModule);
// sitefinityExtensionsStore.addExtensionModule(ThemeModule);
// sitefinityExtensionsStore.addExtensionModule(FieldsChangeModule);
//sitefinityExtensionsStore.addExtensionModule(WidgetEditorExtenderModule);
// sitefinityExtensionsStore.addExtensionModule(RelatedDateExtenderModule);


/***/ }),

/***/ "ext_mod_id_1649152171063_1":
/*!*****************************************!*\
  !*** multi ./src/__extensions_index.ts ***!
  \*****************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __webpack_require__(/*! D:\02_LEARN\07_SITEFINITY\sitefinity-admin-app-extensions\src\__extensions_index.ts */"ext_mod_id_1649152171063");


/***/ }),

/***/ "ext_mod_id_1649152171063_10":
/*!****************************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js ***!
  \****************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";


var isOldIE = function isOldIE() {
  var memo;
  return function memorize() {
    if (typeof memo === 'undefined') {
      // Test for IE <= 9 as proposed by Browserhacks
      // @see http://browserhacks.com/#hack-e71d8692f65334173fee715c222cb805
      // Tests for existence of standard globals is to allow style-loader
      // to operate correctly into non-standard environments
      // @see https://github.com/webpack-contrib/style-loader/issues/177
      memo = Boolean(window && document && document.all && !window.atob);
    }

    return memo;
  };
}();

var getTarget = function getTarget() {
  var memo = {};
  return function memorize(target) {
    if (typeof memo[target] === 'undefined') {
      var styleTarget = document.querySelector(target); // Special case to return head of iframe instead of iframe itself

      if (window.HTMLIFrameElement && styleTarget instanceof window.HTMLIFrameElement) {
        try {
          // This will throw an exception if access to iframe is blocked
          // due to cross-origin restrictions
          styleTarget = styleTarget.contentDocument.head;
        } catch (e) {
          // istanbul ignore next
          styleTarget = null;
        }
      }

      memo[target] = styleTarget;
    }

    return memo[target];
  };
}();

var stylesInDom = [];

function getIndexByIdentifier(identifier) {
  var result = -1;

  for (var i = 0; i < stylesInDom.length; i++) {
    if (stylesInDom[i].identifier === identifier) {
      result = i;
      break;
    }
  }

  return result;
}

function modulesToDom(list, options) {
  var idCountMap = {};
  var identifiers = [];

  for (var i = 0; i < list.length; i++) {
    var item = list[i];
    var id = options.base ? item[0] + options.base : item[0];
    var count = idCountMap[id] || 0;
    var identifier = "".concat(id, " ").concat(count);
    idCountMap[id] = count + 1;
    var index = getIndexByIdentifier(identifier);
    var obj = {
      css: item[1],
      media: item[2],
      sourceMap: item[3]
    };

    if (index !== -1) {
      stylesInDom[index].references++;
      stylesInDom[index].updater(obj);
    } else {
      stylesInDom.push({
        identifier: identifier,
        updater: addStyle(obj, options),
        references: 1
      });
    }

    identifiers.push(identifier);
  }

  return identifiers;
}

function insertStyleElement(options) {
  var style = document.createElement('style');
  var attributes = options.attributes || {};

  if (typeof attributes.nonce === 'undefined') {
    var nonce =  true ? __webpack_require__.nc : undefined;

    if (nonce) {
      attributes.nonce = nonce;
    }
  }

  Object.keys(attributes).forEach(function (key) {
    style.setAttribute(key, attributes[key]);
  });

  if (typeof options.insert === 'function') {
    options.insert(style);
  } else {
    var target = getTarget(options.insert || 'head');

    if (!target) {
      throw new Error("Couldn't find a style target. This probably means that the value for the 'insert' parameter is invalid.");
    }

    target.appendChild(style);
  }

  return style;
}

function removeStyleElement(style) {
  // istanbul ignore if
  if (style.parentNode === null) {
    return false;
  }

  style.parentNode.removeChild(style);
}
/* istanbul ignore next  */


var replaceText = function replaceText() {
  var textStore = [];
  return function replace(index, replacement) {
    textStore[index] = replacement;
    return textStore.filter(Boolean).join('\n');
  };
}();

function applyToSingletonTag(style, index, remove, obj) {
  var css = remove ? '' : obj.media ? "@media ".concat(obj.media, " {").concat(obj.css, "}") : obj.css; // For old IE

  /* istanbul ignore if  */

  if (style.styleSheet) {
    style.styleSheet.cssText = replaceText(index, css);
  } else {
    var cssNode = document.createTextNode(css);
    var childNodes = style.childNodes;

    if (childNodes[index]) {
      style.removeChild(childNodes[index]);
    }

    if (childNodes.length) {
      style.insertBefore(cssNode, childNodes[index]);
    } else {
      style.appendChild(cssNode);
    }
  }
}

function applyToTag(style, options, obj) {
  var css = obj.css;
  var media = obj.media;
  var sourceMap = obj.sourceMap;

  if (media) {
    style.setAttribute('media', media);
  } else {
    style.removeAttribute('media');
  }

  if (sourceMap && btoa) {
    css += "\n/*# sourceMappingURL=data:application/json;base64,".concat(btoa(unescape(encodeURIComponent(JSON.stringify(sourceMap)))), " */");
  } // For old IE

  /* istanbul ignore if  */


  if (style.styleSheet) {
    style.styleSheet.cssText = css;
  } else {
    while (style.firstChild) {
      style.removeChild(style.firstChild);
    }

    style.appendChild(document.createTextNode(css));
  }
}

var singleton = null;
var singletonCounter = 0;

function addStyle(obj, options) {
  var style;
  var update;
  var remove;

  if (options.singleton) {
    var styleIndex = singletonCounter++;
    style = singleton || (singleton = insertStyleElement(options));
    update = applyToSingletonTag.bind(null, style, styleIndex, false);
    remove = applyToSingletonTag.bind(null, style, styleIndex, true);
  } else {
    style = insertStyleElement(options);
    update = applyToTag.bind(null, style, options);

    remove = function remove() {
      removeStyleElement(style);
    };
  }

  update(obj);
  return function updateStyle(newObj) {
    if (newObj) {
      if (newObj.css === obj.css && newObj.media === obj.media && newObj.sourceMap === obj.sourceMap) {
        return;
      }

      update(obj = newObj);
    } else {
      remove();
    }
  };
}

module.exports = function (list, options) {
  options = options || {}; // Force single-tag solution on IE6-9, which has a hard limit on the # of <style>
  // tags it will allow on a page

  if (!options.singleton && typeof options.singleton !== 'boolean') {
    options.singleton = isOldIE();
  }

  list = list || [];
  var lastIdentifiers = modulesToDom(list, options);
  return function update(newList) {
    newList = newList || [];

    if (Object.prototype.toString.call(newList) !== '[object Array]') {
      return;
    }

    for (var i = 0; i < lastIdentifiers.length; i++) {
      var identifier = lastIdentifiers[i];
      var index = getIndexByIdentifier(identifier);
      stylesInDom[index].references--;
    }

    var newLastIdentifiers = modulesToDom(newList, options);

    for (var _i = 0; _i < lastIdentifiers.length; _i++) {
      var _identifier = lastIdentifiers[_i];

      var _index = getIndexByIdentifier(_identifier);

      if (stylesInDom[_index].references === 0) {
        stylesInDom[_index].updater();

        stylesInDom.splice(_index, 1);
      }
    }

    lastIdentifiers = newLastIdentifiers;
  };
};

/***/ }),

/***/ "ext_mod_id_1649152171063_11":
/*!*********************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./src/editor-extender/word-count/editor-config-provider.css ***!
  \*********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Imports
var ___CSS_LOADER_API_IMPORT___ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1649152171063_12");
exports = ___CSS_LOADER_API_IMPORT___(false);
// Module
exports.push([module.i, ".k-editor-toolbar .k-i-Words-count::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e696\";\r\n}\r\n", ""]);
// Exports
module.exports = exports;


/***/ }),

/***/ "ext_mod_id_1649152171063_12":
/*!*****************************************************!*\
  !*** ./node_modules/css-loader/dist/runtime/api.js ***!
  \*****************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

"use strict";

/*
  MIT License http://www.opensource.org/licenses/mit-license.php
  Author Tobias Koppers @sokra
*/
// css base code, injected by the css-loader
// eslint-disable-next-line func-names

module.exports = function (useSourceMap) {
  var list = []; // return the list of modules as css string

  list.toString = function toString() {
    return this.map(function (item) {
      var content = cssWithMappingToString(item, useSourceMap);

      if (item[2]) {
        return "@media ".concat(item[2], " {").concat(content, "}");
      }

      return content;
    }).join('');
  }; // import a list of modules into the list
  // eslint-disable-next-line func-names


  list.i = function (modules, mediaQuery, dedupe) {
    if (typeof modules === 'string') {
      // eslint-disable-next-line no-param-reassign
      modules = [[null, modules, '']];
    }

    var alreadyImportedModules = {};

    if (dedupe) {
      for (var i = 0; i < this.length; i++) {
        // eslint-disable-next-line prefer-destructuring
        var id = this[i][0];

        if (id != null) {
          alreadyImportedModules[id] = true;
        }
      }
    }

    for (var _i = 0; _i < modules.length; _i++) {
      var item = [].concat(modules[_i]);

      if (dedupe && alreadyImportedModules[item[0]]) {
        // eslint-disable-next-line no-continue
        continue;
      }

      if (mediaQuery) {
        if (!item[2]) {
          item[2] = mediaQuery;
        } else {
          item[2] = "".concat(mediaQuery, " and ").concat(item[2]);
        }
      }

      list.push(item);
    }
  };

  return list;
};

function cssWithMappingToString(item, useSourceMap) {
  var content = item[1] || ''; // eslint-disable-next-line prefer-destructuring

  var cssMapping = item[3];

  if (!cssMapping) {
    return content;
  }

  if (useSourceMap && typeof btoa === 'function') {
    var sourceMapping = toComment(cssMapping);
    var sourceURLs = cssMapping.sources.map(function (source) {
      return "/*# sourceURL=".concat(cssMapping.sourceRoot || '').concat(source, " */");
    });
    return [content].concat(sourceURLs).concat([sourceMapping]).join('\n');
  }

  return [content].join('\n');
} // Adapted from convert-source-map (MIT)


function toComment(sourceMap) {
  // eslint-disable-next-line no-undef
  var base64 = btoa(unescape(encodeURIComponent(JSON.stringify(sourceMap))));
  var data = "sourceMappingURL=data:application/json;charset=utf-8;base64,".concat(base64);
  return "/*# ".concat(data, " */");
}

/***/ }),

/***/ "ext_mod_id_1649152171063_13":
/*!******************************************************************************************!*\
  !*** ./src/editor-extender/sitefinity-videos/sitefinity-videos-toolbar-item-provider.ts ***!
  \******************************************************************************************/
/*! exports provided: ensureTrailingBreaks, VIDEO_TOOLBAR_ITEM_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ensureTrailingBreaks", function() { return ensureTrailingBreaks; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "VIDEO_TOOLBAR_ITEM_PROVIDER", function() { return VIDEO_TOOLBAR_ITEM_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



// This is webpack specific loader syntax for injecting css as <style> tag in header
__webpack_require__(/*! style-loader!css-loader!./sitefinity-videos-toolbar-item-provider.css */ "ext_mod_id_1649152171063_14");
var TRAILING_BREAK = "<br class='k-br'>";
var ensureTrailingBreaks = function (html) {
    return "" + TRAILING_BREAK + html + TRAILING_BREAK;
};
/**
 * A custom toolbar provider implementation for inserting existing videos in the editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
var VideosToolbarItemProvider = /** @class */ (function () {
    function VideosToolbarItemProvider(selectorService) {
        this.selectorService = selectorService;
    }
    VideosToolbarItemProvider.prototype.getToolBarItems = function (editorHost) {
        var _this = this;
        var CUSTOM_TOOLBAR_ITEM = {
            name: "Sitefinity-videos",
            tooltip: "Sitefinity videos",
            ordinal: 6,
            exec: function () {
                var editor = editorHost.getKendoEditor();
                // Save editor's current range, so we can insert
                // later the HTML at this position.
                var currentRange = editor.getRange();
                var selectorOptions = {
                    multiple: true
                };
                // open the selector and subscribe to the result
                _this.selectorService.openVideoLibrarySelector(selectorOptions).subscribe(function (videos) {
                    if (videos.length) {
                        // Restore editor's saved position.
                        editor.selectRange(currentRange);
                        videos.forEach(function (video) {
                            var videoElement = document.createElement("video");
                            // Disable video playing, but show controls,
                            // so the video can be playable on the frontend.
                            videoElement.contentEditable = "false";
                            videoElement.src = video.url;
                            videoElement.setAttribute("controls", "true");
                            // Insert the HTML and trigger editor's change, so the
                            // HTML can be saved.
                            editor.paste(ensureTrailingBreaks(videoElement.outerHTML));
                            editor.trigger("change");
                        });
                    }
                });
            }
        };
        return [CUSTOM_TOOLBAR_ITEM];
    };
    VideosToolbarItemProvider.prototype.getToolBarItemsNamesToRemove = function () {
        // If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
        // Otherwise return an empty array.
        // Example: return [ "embed" ];
        // The above code will remove the embed toolbar item from the editor.
        return [];
    };
    VideosToolbarItemProvider.ctorParameters = function () { return [
        { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"], args: [_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["SELECTOR_SERVICE"],] }] }
    ]; };
    VideosToolbarItemProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"])("design:paramtypes", [Object])
    ], VideosToolbarItemProvider);
    return VideosToolbarItemProvider;
}());
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
var VIDEO_TOOLBAR_ITEM_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["TOOLBARITEMS_TOKEN"],
    useClass: VideosToolbarItemProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_14":
/*!*************************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./src/editor-extender/sitefinity-videos/sitefinity-videos-toolbar-item-provider.css ***!
  \*************************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var api = __webpack_require__(/*! ../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1649152171063_10");
            var content = __webpack_require__(/*! !../../../node_modules/css-loader/dist/cjs.js!./sitefinity-videos-toolbar-item-provider.css */ "ext_mod_id_1649152171063_15");

            content = content.__esModule ? content.default : content;

            if (typeof content === 'string') {
              content = [[module.i, content, '']];
            }

var options = {};

options.insert = "head";
options.singleton = false;

var update = api(content, options);



module.exports = content.locals || {};

/***/ }),

/***/ "ext_mod_id_1649152171063_15":
/*!*********************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./src/editor-extender/sitefinity-videos/sitefinity-videos-toolbar-item-provider.css ***!
  \*********************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Imports
var ___CSS_LOADER_API_IMPORT___ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1649152171063_12");
exports = ___CSS_LOADER_API_IMPORT___(false);
// Module
exports.push([module.i, ".k-editor-toolbar .k-i-Sitefinity-videos::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e659\";\r\n}\r\n", ""]);
// Exports
module.exports = exports;


/***/ }),

/***/ "ext_mod_id_1649152171063_16":
/*!*************************************************************************************!*\
  !*** ./src/editor-extender/switch-text-direction/switch-text-direction.provider.ts ***!
  \*************************************************************************************/
/*! exports provided: SWITCH_TEXT_DIRECTION_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "SWITCH_TEXT_DIRECTION_PROVIDER", function() { return SWITCH_TEXT_DIRECTION_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1649152171063_17");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "ext_mod_id_1649152171063_18");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__);





// These classes are defined in the application's styles.
var RTL_CLASS = "-sf-direction-rtl";
var LTR_CLASS = "-sf-direction-ltr";
var SELECTED_CLASS = "k-state-selected";
var LTR_BUTTON_SELECTOR = ".k-i-Left-to-right";
var RTL_BUTTON_SELECTOR = ".k-i-Right-to-left";
var KENDO_EDITOR_CLASS = "k-editor";
var SF_EDITOR_TAG_NAME = "sf-editor";
var EDIT_MENU_SELECTOR = "sf-edit-menu";
var TOOLBAR_BUTTONS_DATA = {
    LTR: {
        name: "Left-to-right",
        tooltip: "Left-to-right"
    },
    RTL: {
        name: "Right-to-left",
        tooltip: "Right-to-left"
    }
};
var arrowKeycodes = new Set([37, 38, 39, 40]);
var SelectionDirection;
(function (SelectionDirection) {
    SelectionDirection[SelectionDirection["topToBottom"] = 0] = "topToBottom";
    SelectionDirection[SelectionDirection["bottomToTop"] = 1] = "bottomToTop";
})(SelectionDirection || (SelectionDirection = {}));
__webpack_require__(/*! style-loader!css-loader!./switch-text-direction.provider.css */ "ext_mod_id_1649152171063_19");
var SwitchTextDirectionProvider = /** @class */ (function () {
    function SwitchTextDirectionProvider() {
    }
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     *
     * @param {*} editorHost The Kendo's editor object.
     * @returns {ToolBarItem[]} The custom toolbar items that will be added to the Kendo's toolbar.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.getToolBarItems = function (editorHost) {
        var _this = this;
        this.handleCursorMove(editorHost);
        var SWITCH_LEFT_TO_RIGHT_TOOL = {
            name: TOOLBAR_BUTTONS_DATA.LTR.name,
            tooltip: TOOLBAR_BUTTONS_DATA.LTR.tooltip,
            ordinal: 6,
            exec: function () {
                var ltrButtonParent = jQuery(LTR_BUTTON_SELECTOR).parent()[0];
                _this.handleExec(ltrButtonParent, editorHost, LTR_CLASS, function () { return _this.handleButtonStylesOnLTRButtonClicked(editorHost); });
            }
        };
        var SWITCH_RIGHT_TO_LEFT_TOOL = {
            name: TOOLBAR_BUTTONS_DATA.RTL.name,
            tooltip: TOOLBAR_BUTTONS_DATA.RTL.tooltip,
            ordinal: 7,
            exec: function () {
                var rtlButtonParent = jQuery(RTL_BUTTON_SELECTOR).parent()[0];
                _this.handleExec(rtlButtonParent, editorHost, RTL_CLASS, function () { return _this.handleButtonStylesOnRTLButtonClicked(editorHost); });
            }
        };
        // Should group the direction buttons once the editor is loaded and focused.
        Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["fromEvent"])(editorHost[0], "focusin")
            .pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["first"])())
            .subscribe(function () {
            var toolbar = editorHost.getKendoEditor().toolbar.element;
            Object(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["groupToolbarButtons"])(toolbar, RTL_BUTTON_SELECTOR, LTR_BUTTON_SELECTOR, false);
        });
        return [SWITCH_LEFT_TO_RIGHT_TOOL, SWITCH_RIGHT_TO_LEFT_TOOL];
    };
    /**
     * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
     * Otherwise return an empty array.
     * Example: return [ "embed" ];
     * The above code will remove the embed toolbar item from the editor.
     *
     * @returns {string[]}
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.getToolBarItemsNamesToRemove = function () {
        return [];
    };
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration overview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     *
     * @param {*} configuration
     * @returns The modified configuration.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.configureEditor = function (configuration) {
        return configuration;
    };
    /**
     * Finds the parent element of the one that is the caret on.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @returns {HTMLElement}
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.findParent = function (editorHost) {
        var editor = editorHost.getKendoEditor();
        var currentNode = editor.getRange().startContainer;
        if (currentNode.nodeName === "#text") {
            currentNode = currentNode.parentElement;
        }
        // When the editor returns itself as current element, we should find the first child
        // where the actual content is. The hierarchy is sf-editor -> div.k-editor -> actual content
        if (currentNode.tagName && currentNode.tagName.toLocaleLowerCase() === SF_EDITOR_TAG_NAME) {
            return currentNode.firstElementChild.firstElementChild;
        }
        while (this.isInlineElement(currentNode)) {
            currentNode = currentNode.parentElement;
        }
        // When the editor returns div.k-editor that means there isn't any formatting,
        // so we have to wrap the raw content in some element because otherwise we add
        // the class globally for the whole editor.
        if (currentNode.classList.contains(KENDO_EDITOR_CLASS)) {
            var wrapper = document.createElement("p");
            wrapper.innerHTML = currentNode.innerHTML;
            currentNode.innerHTML = "";
            currentNode.appendChild(wrapper);
            currentNode = wrapper;
        }
        return currentNode;
    };
    /**
     * Make the LTR button selected, and the RTL button unselected.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.handleButtonStylesOnLTRButtonClicked = function (editorHost) {
        this.getToolbarButton(editorHost, LTR_BUTTON_SELECTOR).classList.add(SELECTED_CLASS);
        this.getToolbarButton(editorHost, RTL_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
    };
    /**
     * Make the RTL button selected, and the LTR button unselected.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.handleButtonStylesOnRTLButtonClicked = function (editorHost) {
        this.getToolbarButton(editorHost, RTL_BUTTON_SELECTOR).classList.add(SELECTED_CLASS);
        this.getToolbarButton(editorHost, LTR_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
    };
    /**
     * Determines if the passed element has display: inline.
     *
     * @private
     * @param {HTMLElement} element The element which will be checked.
     * @returns True if the element is inline, otherwise false.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.isInlineElement = function (element) {
        var style = getComputedStyle(element, "");
        return style.display === "inline";
    };
    /**
     * Retrieves toolbar button by given class.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @param {string} selector The selector for which the button will be queried.
     * @returns {HTMLElement}
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.getToolbarButton = function (editorHost, selector) {
        return editorHost
            .getKendoEditor()
            .toolbar
            .element[0]
            .querySelector(selector)
            .parentElement;
    };
    /**
     * When the caret's position is changed by clicking in the editor or
     * by navigating with the arrows, the toolbar's buttons should have
     * the correct selected state, depending on the direction of the element
     * on which the caret is.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.handleCursorMove = function (editorHost) {
        var _this = this;
        var editorElement = editorHost[0];
        var toggleToolbarButtonsSelectedClasses = function () {
            var parent = _this.findParent(editorHost);
            if (!parent) {
                return;
            }
            // When the parent doesn't have classes, this means it is just a kendo wrapper.
            if (!parent.classList.length) {
                parent = parent.parentElement;
            }
            if (parent.classList.contains(LTR_CLASS)) {
                _this.handleButtonStylesOnLTRButtonClicked(editorHost);
            }
            else if (parent.classList.contains(RTL_CLASS) && !parent.classList.contains(KENDO_EDITOR_CLASS)) {
                _this.handleButtonStylesOnRTLButtonClicked(editorHost);
            }
            else {
                _this.turnOffSelectedButtons(editorHost);
            }
        };
        editorElement.addEventListener("click", function () { return toggleToolbarButtonsSelectedClasses(); });
        editorElement.addEventListener("keydown", function (ev) {
            if (arrowKeycodes.has(ev.keyCode)) {
                toggleToolbarButtonsSelectedClasses();
            }
            else if (!editorElement.textContent) {
                _this.turnOffSelectedButtons(editorHost);
            }
        });
    };
    /**
     * When there is selection, all the selected nodes should have the specified
     * direction.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @param {string} classToAdd The class that should be added on each of the nodes that are in the selection.
     * @param {Function} doneCb Function that is called when the processing of the selection is done. It's called only when there is particular selection.
     * @returns {boolean}
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.tryHandleSelection = function (toolbarButton, editorHost, classToAdd, doneCb) {
        var selection = editorHost.getKendoEditor().getSelection();
        var selectionDirection = this.getSelectionDirection(selection);
        var baseNode = selection.baseNode || selection.anchorNode;
        if (!selection.isCollapsed && selection.focusNode !== baseNode) {
            var node = selection.focusNode;
            while (selection.containsNode(node)) {
                if (toolbarButton.classList.contains(SELECTED_CLASS)) {
                    this.removeDirection(toolbarButton, node.parentElement, classToAdd);
                }
                else {
                    this.setDirection(node.parentElement, classToAdd);
                }
                if (selectionDirection === SelectionDirection.topToBottom) {
                    if (!node.parentElement.previousElementSibling || !node.parentElement.previousElementSibling.firstChild) {
                        break;
                    }
                    node = node.parentElement.previousElementSibling.firstChild;
                }
                else {
                    if (!node.parentElement.nextElementSibling || !node.parentElement.nextElementSibling.firstChild) {
                        break;
                    }
                    node = node.parentElement.nextElementSibling.firstChild;
                }
            }
            doneCb();
            return true;
        }
        return false;
    };
    /**
     * Determines when the selections starts from top to bottom
     * or from bottom to top.
     *
     * @private
     * @param {*} selection Current selection.
     * @returns {SelectionDirection} Selection's direction.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.getSelectionDirection = function (selection) {
        var focusNode = selection.focusNode;
        // Workaround for firefox. The selection API does not provide baseNode. The alternative is anchorNode.
        var baseNode = selection.baseNode || selection.anchorNode;
        var positionA = focusNode.compareDocumentPosition(baseNode);
        var positionB = baseNode.compareDocumentPosition(focusNode);
        var isBefore = positionB > positionA;
        if (isBefore) {
            return SelectionDirection.topToBottom;
        }
        return SelectionDirection.bottomToTop;
    };
    /**
     * Handles toolbar button click.
     *
     * @private
     * @param {*} toolbarButton kendo toolbar button for rtl or ltr direction.
     * @param {*} editorHost The Kendo's editor object.
     * @param {string} dirClassToAdd Text direction class that will be added to the current element or the elements in the selection.
     * @param {Function} applyButtonStyles Function that applies styles to the toolbar buttons.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.handleExec = function (toolbarButton, editorHost, dirClassToAdd, applyButtonStyles) {
        jQuery(EDIT_MENU_SELECTOR).hide();
        if (!this.tryHandleSelection(toolbarButton, editorHost, dirClassToAdd, function () { return applyButtonStyles(); })) {
            var elementContainer = this.findParent(editorHost);
            if (toolbarButton.classList.contains(SELECTED_CLASS)) {
                this.removeDirection(toolbarButton, elementContainer, dirClassToAdd);
            }
            else {
                this.setDirection(elementContainer, dirClassToAdd);
                applyButtonStyles();
            }
        }
    };
    /**
     * Returns toolbar buttons to their normal state.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.turnOffSelectedButtons = function (editorHost) {
        this.getToolbarButton(editorHost, LTR_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
        this.getToolbarButton(editorHost, RTL_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
    };
    /**
     * Checks desired text direction and sets required styles.
     *
     * @private
     * @param {*} elementToStyle the element that has to be styled.
     * @param {*} classToAdd RTL or LTR class to be added to the element.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.setDirection = function (elementToStyle, classToAdd) {
        if (classToAdd === RTL_CLASS) {
            this.setDirectionStyles(elementToStyle, LTR_CLASS, "rtl", "right", RTL_CLASS);
        }
        else {
            this.setDirectionStyles(elementToStyle, RTL_CLASS, "ltr", "left", LTR_CLASS);
        }
    };
    /**
     * Removes text direction styles.
     *
     * @private
     * @param {*} toolbarButton kendo toolbar button for rtl or ltr direction.
     * @param {*} elementToStyle the element that has to be styled.
     * @param {*} classToRemove RTL or LTR class to be removed to the element.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.removeDirection = function (toolbarButton, elementToStyle, classToRemove) {
        this.setDirectionStyles(elementToStyle, classToRemove, null, null);
        toolbarButton.classList.remove(SELECTED_CLASS);
    };
    /**
     * Sets required styles for text direction.
     *
     * @private
     * @param {*} elementToStyle the element that has to be styled.
     * @param {*} classToAdd RTL or LTR class to be added to the element.
     * @param {*} classToRemove RTL or LTR class to be removed from the element.
     * @param {*} directionStyle rtl or ltr css direction property value to be set to the element.
     * @param {*} alignmentStyle right or left css text-align property value to be set to the element.
     * @memberof SwitchTextDirectionProvider
     */
    SwitchTextDirectionProvider.prototype.setDirectionStyles = function (elementToStyle, classToRemove, directionStyle, alignmentStyle, classToAdd) {
        elementToStyle.classList.remove(classToRemove);
        if (classToAdd) {
            elementToStyle.classList.add(classToAdd);
        }
        elementToStyle.style.direction = directionStyle;
        elementToStyle.style.textAlign = alignmentStyle;
    };
    SwitchTextDirectionProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
    ], SwitchTextDirectionProvider);
    return SwitchTextDirectionProvider;
}());
var SWITCH_TEXT_DIRECTION_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["TOOLBARITEMS_TOKEN"],
    useClass: SwitchTextDirectionProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_17":
/*!***********************************************************************************!*\
  !*** delegated ./node_modules/rxjs/_esm2015/index.js from dll-reference adminapp ***!
  \***********************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/rxjs/_esm2015/index.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_18":
/*!*********************************************************************************************!*\
  !*** delegated ./node_modules/rxjs/_esm2015/operators/index.js from dll-reference adminapp ***!
  \*********************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/rxjs/_esm2015/operators/index.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_19":
/*!********************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./src/editor-extender/switch-text-direction/switch-text-direction.provider.css ***!
  \********************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var api = __webpack_require__(/*! ../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1649152171063_10");
            var content = __webpack_require__(/*! !../../../node_modules/css-loader/dist/cjs.js!./switch-text-direction.provider.css */ "ext_mod_id_1649152171063_20");

            content = content.__esModule ? content.default : content;

            if (typeof content === 'string') {
              content = [[module.i, content, '']];
            }

var options = {};

options.insert = "head";
options.singleton = false;

var update = api(content, options);



module.exports = content.locals || {};

/***/ }),

/***/ "ext_mod_id_1649152171063_2":
/*!**************************************!*\
  !*** ./src/editor-extender/index.ts ***!
  \**************************************/
/*! exports provided: EditorExtenderModule */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EditorExtenderModule", function() { return EditorExtenderModule; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ext_mod_id_1649152171063_6");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_common__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _word_count_word_count_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./word-count/word-count-provider */ "ext_mod_id_1649152171063_7");
/* harmony import */ var _sitefinity_videos_sitefinity_videos_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./sitefinity-videos/sitefinity-videos-toolbar-item-provider */ "ext_mod_id_1649152171063_13");
/* harmony import */ var _switch_text_direction_switch_text_direction_provider__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./switch-text-direction/switch-text-direction.provider */ "ext_mod_id_1649152171063_16");
/* harmony import */ var _insert_bootstrap_icon_insert_bootstrap_icon_provider__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./insert-bootstrap-icon/insert-bootstrap-icon.provider */ "ext_mod_id_1649152171063_21");
/* harmony import */ var _spell_check_edit_menu_spell_check_provider__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./spell-check/edit-menu-spell-check-provider */ "ext_mod_id_1649152171063_27");
/* harmony import */ var _spell_check_editor_spell_check_provider__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./spell-check/editor-spell-check-provider */ "ext_mod_id_1649152171063_28");
/* harmony import */ var _sitefinity_images_sitefinity_images_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./sitefinity-images/sitefinity-images-toolbar-item-provider */ "ext_mod_id_1649152171063_32");










/**
 * The toolbar extender module.
 */
var EditorExtenderModule = /** @class */ (function () {
    function EditorExtenderModule() {
    }
    EditorExtenderModule = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
            providers: [
                _word_count_word_count_provider__WEBPACK_IMPORTED_MODULE_3__["WORD_COUNT_PROVIDER"],
                _sitefinity_videos_sitefinity_videos_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_4__["VIDEO_TOOLBAR_ITEM_PROVIDER"],
                _switch_text_direction_switch_text_direction_provider__WEBPACK_IMPORTED_MODULE_5__["SWITCH_TEXT_DIRECTION_PROVIDER"],
                _insert_bootstrap_icon_insert_bootstrap_icon_provider__WEBPACK_IMPORTED_MODULE_6__["INSERT_BOOTSTRAP_ICON_PROVIDER"],
                _spell_check_editor_spell_check_provider__WEBPACK_IMPORTED_MODULE_8__["EDITOR_SPELL_CHECK_PROVIDER"],
                _spell_check_edit_menu_spell_check_provider__WEBPACK_IMPORTED_MODULE_7__["EDIT_MENU_SPELL_CHECK_PROVIDER"],
                _sitefinity_images_sitefinity_images_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_9__["IMAGE_TOOLBAR_ITEM_PROVIDER"]
            ],
            imports: [
                _angular_common__WEBPACK_IMPORTED_MODULE_2__["CommonModule"]
            ]
        })
    ], EditorExtenderModule);
    return EditorExtenderModule;
}());



/***/ }),

/***/ "ext_mod_id_1649152171063_20":
/*!****************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./src/editor-extender/switch-text-direction/switch-text-direction.provider.css ***!
  \****************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Imports
var ___CSS_LOADER_API_IMPORT___ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1649152171063_12");
exports = ___CSS_LOADER_API_IMPORT___(false);
// Module
exports.push([module.i, ".k-icon.k-i-Left-to-right,\r\n.k-icon.k-i-Right-to-left {\r\n    font-family: FontAwesome;\r\n    font-size: 16px !important;\r\n    width: auto !important;\r\n}\r\n\r\n.k-i-Right-to-left::after {\r\n    content: \"\\f0d9\";\r\n}\r\n\r\n.k-i-Right-to-left::before {\r\n    content: \"\\f1dd\";\r\n}\r\n\r\n.k-i-Left-to-right::after {\r\n    content: \"\\f1dd\";\r\n}\r\n\r\n.k-i-Left-to-right::before {\r\n    content: \"\\f0da\";\r\n    margin-left: 15px;\r\n}\r\n\r\n.k-icon.k-i-Left-to-right::before,\r\n.k-icon.k-i-Right-to-left::before {\r\n    padding-right: 0;\r\n    width: auto !important;\r\n}\r\n\r\n.k-icon.k-i-Left-to-right::after,\r\n.k-icon.k-i-Right-to-left::after {\r\n    padding: 5px 5px 5px 0;\r\n    height: 25px !important;\r\n}\r\n\r\n.k-icon.k-i-Right-to-left::before {\r\n    margin-right: 0 !important;\r\n}\r\n\r\n.k-icon.k-i-Right-to-left::after {\r\n    margin-right: 15px;\r\n}\r\n\r\n.k-state-selected .k-icon::after {\r\n    background-color: #e4e4e4;\r\n    border-radius: 0;\r\n}\r\n", ""]);
// Exports
module.exports = exports;


/***/ }),

/***/ "ext_mod_id_1649152171063_21":
/*!*************************************************************************************!*\
  !*** ./src/editor-extender/insert-bootstrap-icon/insert-bootstrap-icon.provider.ts ***!
  \*************************************************************************************/
/*! exports provided: INSERT_BOOTSTRAP_ICON_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "INSERT_BOOTSTRAP_ICON_PROVIDER", function() { return INSERT_BOOTSTRAP_ICON_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _symbol_list_insert_symbol_generator__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./symbol-list/insert-symbol-generator */ "ext_mod_id_1649152171063_22");
/* harmony import */ var _helpers_tool_builder__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../helpers/tool-builder */ "ext_mod_id_1649152171063_23");
/* harmony import */ var _symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./symbol-list/symbol-list.json */ "ext_mod_id_1649152171063_26");
var _symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5___namespace = /*#__PURE__*/__webpack_require__.t(/*! ./symbol-list/symbol-list.json */ "ext_mod_id_1649152171063_26", 1);





var TOOLBAR_BUTTON_DATA = {
    DEFAULT: {
        name: "insertbootstrapicon",
        tooltip: "Insert Bootstrap Icon"
    }
};
__webpack_require__(/*! style-loader!css-loader!./insert-bootstrap-icon.provider.css */ "ext_mod_id_1649152171063_24");

var InsertBootstrapIconProvider = /** @class */ (function () {
    function InsertBootstrapIconProvider() {
    }
    /**
     * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
     * Otherwise return an empty array.
     * Example: return [ "embed" ];
     * The above code will remove the embed toolbar item from the editor.
     * Documentation where you can find all tools' names: https://docs.telerik.com/kendo-ui/api/javascript/ui/editor/configuration/tools
     *
     * @returns {string[]}
     * @memberof InsertSymbolProvider
     */
    InsertBootstrapIconProvider.prototype.getToolBarItemsNamesToRemove = function () {
        return [];
    };
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration overview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     *
     * @param {*} configuration
     * @returns The modified configuration.
     * @memberof InsertSymbolProvider
     */
    InsertBootstrapIconProvider.prototype.configureEditor = function (configuration) {
        return configuration;
    };
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     *
     * @param {*} editorHost The Kendo's editor object.
     * @returns {ToolBarItem[]} The custom toolbar items that will be added to the Kendo's toolbar.
     * @memberof InsertSymbolProvider
     */
    InsertBootstrapIconProvider.prototype.getToolBarItems = function (editorHost) {
        /**
         * The custom tool.
         */
        var DEFAULT_TOOL = {
            name: TOOLBAR_BUTTON_DATA.DEFAULT.name,
            tooltip: TOOLBAR_BUTTON_DATA.DEFAULT.tooltip,
            ordinal: 30,
            exec: function () { return; }
        };
        this.configureInsertBootstrapIconTool();
        return [DEFAULT_TOOL];
    };
    InsertBootstrapIconProvider.prototype.configureInsertBootstrapIconTool = function () {
        var buttonTemplate = kendo.ui.editor.EditorUtils.buttonTemplate;
        var NS = "kendoEditor";
        var popupTemplateGenerator = function () {
            var symbolGenerator = new _symbol_list_insert_symbol_generator__WEBPACK_IMPORTED_MODULE_3__["InsertSymbolGenerator"](Object.keys(_symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5__).map(function (k) { return _symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5__[k]; }));
            var generatedHtml = symbolGenerator.generateHtml();
            return "<div class='k-ct-popup symbol-popup'><div class='k-status symbol-title'>INSERT SPECIAL CHARACTERS</div>" + generatedHtml + "</div>";
        };
        var config = {
            _activate: function () {
                var that = this;
                var element = that.popup().element;
                element.autoApplyNS(NS).on("down", function (e) {
                    e.preventDefault();
                    var symbolCell = e.target;
                    var symbolValue = symbolCell.getAttribute(_symbol_list_insert_symbol_generator__WEBPACK_IMPORTED_MODULE_3__["DATA_ATTRIBUTE_NAME"]);
                    that._exec(symbolValue);
                });
            },
            _exec: function (sym) {
                // adds the chosen symbol to the editor
                this._editor.paste(sym);
                this._editor.trigger("change");
                this.popup().close();
            },
            _close: function () {
                this.popup().element.off("." + NS);
            }
        };
        var insertSymbolTool = _helpers_tool_builder__WEBPACK_IMPORTED_MODULE_4__["ToolBuilder"].createPopupTool(kendo, TOOLBAR_BUTTON_DATA.DEFAULT.name, config, null, popupTemplateGenerator);
        _helpers_tool_builder__WEBPACK_IMPORTED_MODULE_4__["ToolBuilder"].registerTool(kendo, insertSymbolTool, TOOLBAR_BUTTON_DATA.DEFAULT.name, buttonTemplate, true);
    };
    InsertBootstrapIconProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
    ], InsertBootstrapIconProvider);
    return InsertBootstrapIconProvider;
}());
var INSERT_BOOTSTRAP_ICON_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EDITOR_CONFIG_TOKEN"],
    useClass: InsertBootstrapIconProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_22":
/*!******************************************************************************************!*\
  !*** ./src/editor-extender/insert-bootstrap-icon/symbol-list/insert-symbol-generator.ts ***!
  \******************************************************************************************/
/*! exports provided: DATA_ATTRIBUTE_NAME, InsertSymbolGenerator */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "DATA_ATTRIBUTE_NAME", function() { return DATA_ATTRIBUTE_NAME; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "InsertSymbolGenerator", function() { return InsertSymbolGenerator; });
var DATA_ATTRIBUTE_NAME = "data-value";
/**
 * Represents a helper class for importing a symbol list JSON and  generating html to populate the tool's popup.
 */
var InsertSymbolGenerator = /** @class */ (function () {
    function InsertSymbolGenerator(symbolList) {
        this.symbolConfig = symbolList;
    }
    /**
     * Generates html from a JSON list of symbol models.
     */
    InsertSymbolGenerator.prototype.generateHtml = function () {
        var _this = this;
        var html = "";
        this.symbolConfig.forEach(function (symbol) {
            html = html + _this.generateCell(symbol);
        });
        return html;
    };
    InsertSymbolGenerator.prototype.generateCell = function (symbol) {
        return "<div class=\"symbol-cell\" " + DATA_ATTRIBUTE_NAME + "='" + symbol.value + "' title=\"" + symbol.tooltip + "\">" + symbol.value + "</div>";
    };
    return InsertSymbolGenerator;
}());

var SymbolModel = /** @class */ (function () {
    function SymbolModel() {
    }
    return SymbolModel;
}());


/***/ }),

/***/ "ext_mod_id_1649152171063_23":
/*!*************************************!*\
  !*** ./src/helpers/tool-builder.ts ***!
  \*************************************/
/*! exports provided: ToolBuilder */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ToolBuilder", function() { return ToolBuilder; });
/**
 * Provides an interface for creating and registering custom tools in the Kendo editor.
 */
var ToolBuilder = /** @class */ (function () {
    function ToolBuilder() {
    }
    /**
     * Creates a custom tool that extends the default Kendo popup tool with given configuration.
     * @param kendo Reference to the global kendo script
     * @param toolTitle The title to be used for the tool
     * @param config Configuration object that holds the needed functionality
     * @param command Command name
     * @param popupTemplateGenerator Popup template generator function
     */
    ToolBuilder.createPopupTool = function (kendo, toolTitle, config, command, popupTemplateGenerator) {
        var PopupTool = kendo.ui.editor.PopupTool;
        var defaultConfig = {
            init: function (options) {
                if (config.init) {
                    config.init.bind(this)();
                }
                PopupTool.fn.init.call(this, jQuery.extend(options, {
                    command: command,
                    popupTemplate: popupTemplateGenerator.bind(this)()
                }));
            },
            _open: function () {
                PopupTool.fn._open.call(this);
                if (config._open) {
                    config._open.bind(this)();
                }
            },
            _close: function () {
                PopupTool.fn._close.call(this);
                if (config._close) {
                    config._close.bind(this)();
                }
            }
        };
        for (var functionName in config) {
            if (functionName === "init" || functionName === "_open" || functionName === "_close") {
                continue;
            }
            defaultConfig[functionName] = config[functionName];
        }
        return PopupTool.extend(defaultConfig);
    };
    /**
     * Registers a new custom tool in the Kendo editor, to be inserted later in the toolbar.
     * @param kendo Reference to the global Kendo script
     * @param Tool The generated tool
     * @param toolTitle The title of the tool
     * @param toolTemplate Template for the tool's appearance in the toolbar
     * @param isPopup Whether the tool is a popup or not
     */
    ToolBuilder.registerTool = function (kendo, Tool, toolTitle, toolTemplate, isPopup) {
        if (isPopup === void 0) { isPopup = false; }
        var EditorUtils = kendo.ui.editor.EditorUtils;
        var ToolTemplate = kendo.ui.editor.ToolTemplate;
        EditorUtils.registerTool(toolTitle, new Tool({
            template: new ToolTemplate({
                template: toolTemplate,
                popup: isPopup,
                title: toolTitle
            })
        }));
    };
    return ToolBuilder;
}());



/***/ }),

/***/ "ext_mod_id_1649152171063_24":
/*!********************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./src/editor-extender/insert-bootstrap-icon/insert-bootstrap-icon.provider.css ***!
  \********************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var api = __webpack_require__(/*! ../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1649152171063_10");
            var content = __webpack_require__(/*! !../../../node_modules/css-loader/dist/cjs.js!./insert-bootstrap-icon.provider.css */ "ext_mod_id_1649152171063_25");

            content = content.__esModule ? content.default : content;

            if (typeof content === 'string') {
              content = [[module.i, content, '']];
            }

var options = {};

options.insert = "head";
options.singleton = false;

var update = api(content, options);



module.exports = content.locals || {};

/***/ }),

/***/ "ext_mod_id_1649152171063_25":
/*!****************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./src/editor-extender/insert-bootstrap-icon/insert-bootstrap-icon.provider.css ***!
  \****************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Imports
var ___CSS_LOADER_API_IMPORT___ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1649152171063_12");
exports = ___CSS_LOADER_API_IMPORT___(false);
// Module
exports.push([module.i, ".k-icon.k-i-insertsymbol {\r\n    font-family: WebComponentsIcons;\r\n    font-size: 1.4em;\r\n}\r\n\r\n.k-i-insertsymbol::before {\r\n    font-family: WebComponentsIcons;\r\n    content: \"\\03a9\";\r\n}\r\n\r\n.k-i-insertsymbol::after {\r\n    font-family: WebComponentsIcons;\r\n    content: \"\\e006\";\r\n}\r\n\r\n.k-icon.k-i-insert-symbol::before {\r\n    padding-right: 0;\r\n}\r\n\r\n.k-state-selected .k-icon::after {\r\n    background-color: #e4e4e4;\r\n    border-radius: 0;\r\n}\r\n\r\n.symbol-cell {\r\n    font-size: 15px;\r\n    text-align: center;\r\n    display: inline-block;\r\n    cursor: pointer;\r\n    font-size: 1.1em;\r\n    color: #333333;\r\n    padding: 0px 5px 0px 5px;\r\n}\r\n\r\n.symbol-cell:hover {\r\n    color: #999999;\r\n}\r\n\r\n.k-ct-popup.symbol-popup {\r\n    display: block;\r\n    width: 350px !important;\r\n    padding: 5px 10px 10px 10px !important;\r\n}\r\n\r\n.symbol-title {\r\n    font-size: 10px;\r\n    color: #999999;\r\n    margin: 10px 5px;\r\n}\r\n", ""]);
// Exports
module.exports = exports;


/***/ }),

/***/ "ext_mod_id_1649152171063_26":
/*!********************************************************************************!*\
  !*** ./src/editor-extender/insert-bootstrap-icon/symbol-list/symbol-list.json ***!
  \********************************************************************************/
/*! exports provided: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, default */
/***/ (function(module) {

module.exports = JSON.parse("[{\"name\":\"\\\"\",\"value\":\"\\\"\",\"escapedValue\":\"&amp;quot; &amp;QUOT;\",\"tooltip\":\"QUOTATION MARK\"},{\"name\":\"¢\",\"value\":\"¢\",\"escapedValue\":\"&amp;cent;\",\"tooltip\":\"CENT SIGN\"},{\"name\":\"€\",\"value\":\"€\",\"escapedValue\":\"&amp;euro;\",\"tooltip\":\"EURO SIGN\"},{\"name\":\"£\",\"value\":\"£\",\"escapedValue\":\"&amp;pound;\",\"tooltip\":\"POUND SIGN\"},{\"name\":\"¥\",\"value\":\"¥\",\"escapedValue\":\"&amp;yen;\",\"tooltip\":\"YEN SIGN\"},{\"name\":\"©\",\"value\":\"©\",\"escapedValue\":\"&amp;copy; &amp;COPY;\",\"tooltip\":\"COPYRIGHT SIGN\"},{\"name\":\"®\",\"value\":\"®\",\"escapedValue\":\"&amp;reg; &amp;circledR; &amp;REG;\",\"tooltip\":\"REGISTERED SIGN\"},{\"name\":\"™\",\"value\":\"™\",\"escapedValue\":\"&amp;trade; &amp;TRADE;\",\"tooltip\":\"TRADE MARK SIGN\"},{\"name\":\"‰\",\"value\":\"‰\",\"escapedValue\":\"&amp;permil;\",\"tooltip\":\"PER MILLE SIGN\"},{\"name\":\"µ\",\"value\":\"µ\",\"escapedValue\":\"&amp;micro;\",\"tooltip\":\"MICRO SIGN\"},{\"name\":\"·\",\"value\":\"·\",\"escapedValue\":\"&amp;middot; &amp;centerdot; &amp;CenterDot;\",\"tooltip\":\"MIDDLE DOT\"},{\"name\":\"•\",\"value\":\"•\",\"escapedValue\":\"&amp;bull; &amp;bullet;\",\"tooltip\":\"BULLET\"},{\"name\":\"…\",\"value\":\"…\",\"escapedValue\":\"&amp;hellip; &amp;mldr;\",\"tooltip\":\"HORIZONTAL ELLIPSIS\"},{\"name\":\"′\",\"value\":\"′\",\"escapedValue\":\"&amp;prime;\",\"tooltip\":\"PRIME\"},{\"name\":\"″\",\"value\":\"″\",\"escapedValue\":\"&amp;Prime;\",\"tooltip\":\"DOUBLE PRIME\"},{\"name\":\"§\",\"value\":\"§\",\"escapedValue\":\"&amp;sect;\",\"tooltip\":\"SECTION SIGN\"},{\"name\":\"¶\",\"value\":\"¶\",\"escapedValue\":\"&amp;para;\",\"tooltip\":\"PILCROW SIGN\"},{\"name\":\"ß\",\"value\":\"ß\",\"escapedValue\":\"&amp;szlig;\",\"tooltip\":\"LATIN SMALL LETTER SHARP S\"},{\"name\":\"‹\",\"value\":\"‹\",\"escapedValue\":\"&amp;lsaquo;\",\"tooltip\":\"SINGLE LEFT-POINTING ANGLE QUOTATION MARK\"},{\"name\":\"›\",\"value\":\"›\",\"escapedValue\":\"&amp;rsaquo;\",\"tooltip\":\"SINGLE RIGHT-POINTING ANGLE QUOTATION MARK\"},{\"name\":\"«\",\"value\":\"«\",\"escapedValue\":\"&amp;laquo;\",\"tooltip\":\"LEFT-POINTING DOUBLE ANGLE QUOTATION MARK\"},{\"name\":\"»\",\"value\":\"»\",\"escapedValue\":\"&amp;raquo;\",\"tooltip\":\"RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK\"},{\"name\":\"‘\",\"value\":\"‘\",\"escapedValue\":\"&amp;lsquo; &amp;OpenCurlyQuote;\",\"tooltip\":\"LEFT SINGLE QUOTATION MARK\"},{\"name\":\"’\",\"value\":\"’\",\"escapedValue\":\"&amp;rsquo; &amp;rsquor; &amp;CloseCurlyQuote;\",\"tooltip\":\"RIGHT SINGLE QUOTATION MARK\"},{\"name\":\"“\",\"value\":\"“\",\"escapedValue\":\"&amp;ldquo; &amp;OpenCurlyDoubleQuote;\",\"tooltip\":\"LEFT DOUBLE QUOTATION MARK\"},{\"name\":\"”\",\"value\":\"”\",\"escapedValue\":\"&amp;rdquo; &amp;rdquor; &amp;CloseCurlyDoubleQuote;\",\"tooltip\":\"RIGHT DOUBLE QUOTATION MARK\"},{\"name\":\"‚\",\"value\":\"‚\",\"escapedValue\":\"&amp;lsquor; &amp;sbquo;\",\"tooltip\":\"SINGLE LOW-9 QUOTATION MARK\"},{\"name\":\"„\",\"value\":\"„\",\"escapedValue\":\"&amp;ldquor; &amp;bdquo;\",\"tooltip\":\"DOUBLE LOW-9 QUOTATION MARK\"},{\"name\":\"<\",\"value\":\"<\",\"escapedValue\":\"&amp;lt; &amp;LT;\",\"tooltip\":\"LESS-THAN SIGN\"},{\"name\":\">\",\"value\":\">\",\"escapedValue\":\"&amp;gt; &amp;GT;\",\"tooltip\":\"GREATER-THAN SIGN\"},{\"name\":\"≤\",\"value\":\"≤\",\"escapedValue\":\"&amp;le; &amp;leq;\",\"tooltip\":\"LESS-THAN OR EQUAL TO\"},{\"name\":\"≥\",\"value\":\"≥\",\"escapedValue\":\"&amp;ge; &amp;GreaterEqual; &amp;geq;\",\"tooltip\":\"GREATER-THAN OR EQUAL TO\"},{\"name\":\"–\",\"value\":\"–\",\"escapedValue\":\"&amp;ndash;\",\"tooltip\":\"EN DASH\"},{\"name\":\"—\",\"value\":\"—\",\"escapedValue\":\"&amp;mdash;\",\"tooltip\":\"EM DASH\"},{\"name\":\"¯\",\"value\":\"¯\",\"escapedValue\":\"&amp;macr; &amp;OverBar; &amp;strns;\",\"tooltip\":\"MACRON\"},{\"name\":\"‾\",\"value\":\"‾\",\"escapedValue\":\"&amp;oline;\",\"tooltip\":\"OVERLINE\"},{\"name\":\"¤\",\"value\":\"¤\",\"escapedValue\":\"&amp;curren;\",\"tooltip\":\"CURRENCY SIGN\"},{\"name\":\"¦\",\"value\":\"¦\",\"escapedValue\":\"&amp;brvbar;\",\"tooltip\":\"BROKEN BAR\"},{\"name\":\"¨\",\"value\":\"¨\",\"escapedValue\":\"&amp;Dot; &amp;die; &amp;DoubleDot; &amp;uml;\",\"tooltip\":\"DIAERESIS\"},{\"name\":\"¡\",\"value\":\"¡\",\"escapedValue\":\"&amp;iexcl;\",\"tooltip\":\"INVERTED EXCLAMATION MARK\"},{\"name\":\"¿\",\"value\":\"¿\",\"escapedValue\":\"&amp;iquest;\",\"tooltip\":\"INVERTED QUESTION MARK\"},{\"name\":\"ˆ\",\"value\":\"ˆ\",\"escapedValue\":\"&amp;circ;\",\"tooltip\":\"MODIFIER LETTER CIRCUMFLEX ACCENT\"},{\"name\":\"˜\",\"value\":\"˜\",\"escapedValue\":\"&amp;tilde; &amp;DiacriticalTilde;\",\"tooltip\":\"SMALL TILDE\"},{\"name\":\"°\",\"value\":\"°\",\"escapedValue\":\"&amp;deg;\",\"tooltip\":\"DEGREE SIGN\"},{\"name\":\"−\",\"value\":\"−\",\"escapedValue\":\"&amp;minus;\",\"tooltip\":\"MINUS SIGN\"},{\"name\":\"±\",\"value\":\"±\",\"escapedValue\":\"&amp;plusmn; &amp;pm; &amp;PlusMinus;\",\"tooltip\":\"PLUS-MINUS SIGN\"},{\"name\":\"÷\",\"value\":\"÷\",\"escapedValue\":\"&amp;divide; &amp;div;\",\"tooltip\":\"DIVISION SIGN\"},{\"name\":\"⁄\",\"value\":\"⁄\",\"escapedValue\":\"&amp;frasl;\",\"tooltip\":\"FRACTION SLASH\"},{\"name\":\"×\",\"value\":\"×\",\"escapedValue\":\"&amp;times;\",\"tooltip\":\"MULTIPLICATION SIGN\"},{\"name\":\"¼\",\"value\":\"¼\",\"escapedValue\":\"&amp;frac14;\",\"tooltip\":\"VULGAR FRACTION ONE QUARTER\"},{\"name\":\"½\",\"value\":\"½\",\"escapedValue\":\"&amp;frac12; &amp;half;\",\"tooltip\":\"VULGAR FRACTION ONE HALF\"},{\"name\":\"¾\",\"value\":\"¾\",\"escapedValue\":\"&amp;frac34;\",\"tooltip\":\"VULGAR FRACTION THREE QUARTERS\"},{\"name\":\"ƒ\",\"value\":\"ƒ\",\"escapedValue\":\"&amp;fnof;\",\"tooltip\":\"LATIN SMALL LETTER F WITH HOOK\"},{\"name\":\"∫\",\"value\":\"∫\",\"escapedValue\":\"&amp;int; &amp;Integral;\",\"tooltip\":\"INTEGRAL\"},{\"name\":\"∑\",\"value\":\"∑\",\"escapedValue\":\"&amp;sum; &amp;Sum;\",\"tooltip\":\"N-ARY SUMMATION\"},{\"name\":\"∞\",\"value\":\"∞\",\"escapedValue\":\"&amp;infin;\",\"tooltip\":\"INFINITY\"},{\"name\":\"√\",\"value\":\"√\",\"escapedValue\":\"&amp;radic; &amp;Sqrt;\",\"tooltip\":\"SQUARE ROOT\"},{\"name\":\"∼\",\"value\":\"∼\",\"escapedValue\":\"&amp;sim; &amp;Tilde; &amp;thksim; &amp;thicksim;\",\"tooltip\":\"TILDE OPERATOR\"},{\"name\":\"≅\",\"value\":\"≅\",\"escapedValue\":\"&amp;cong; &amp;TildeFullEqual;\",\"tooltip\":\"APPROXIMATELY EQUAL TO\"},{\"name\":\"≈\",\"value\":\"≈\",\"escapedValue\":\"&amp;asymp; &amp;ap; &amp;TildeTilde; &amp;approx; &amp;thkap; &amp;thickapprox;\",\"tooltip\":\"ALMOST EQUAL TO\"},{\"name\":\"≠\",\"value\":\"≠\",\"escapedValue\":\"&amp;ne; &amp;NotEqual;\",\"tooltip\":\"NOT EQUAL TO\"},{\"name\":\"≡\",\"value\":\"≡\",\"escapedValue\":\"&amp;equiv; &amp;Congruent;\",\"tooltip\":\"IDENTICAL TO\"},{\"name\":\"∈\",\"value\":\"∈\",\"escapedValue\":\"&amp;isin; &amp;isinv; &amp;Element; &amp;in;\",\"tooltip\":\"ELEMENT OF\"},{\"name\":\"∉\",\"value\":\"∉\",\"escapedValue\":\"&amp;notin; &amp;NotElement; &amp;notinva;\",\"tooltip\":\"NOT AN ELEMENT OF\"},{\"name\":\"∋\",\"value\":\"∋\",\"escapedValue\":\"&amp;niv; &amp;ReverseElement; &amp;ni; &amp;SuchThat;\",\"tooltip\":\"CONTAINS AS MEMBER\"},{\"name\":\"∏\",\"value\":\"∏\",\"escapedValue\":\"&amp;prod; &amp;Product;\",\"tooltip\":\"N-ARY PRODUCT\"},{\"name\":\"∧\",\"value\":\"∧\",\"escapedValue\":\"&amp;and; &amp;wedge;\",\"tooltip\":\"LOGICAL AND\"},{\"name\":\"∨\",\"value\":\"∨\",\"escapedValue\":\"&amp;or; &amp;vee;\",\"tooltip\":\"LOGICAL OR\"},{\"name\":\"¬\",\"value\":\"¬\",\"escapedValue\":\"&amp;not;\",\"tooltip\":\"NOT SIGN\"},{\"name\":\"∩\",\"value\":\"∩\",\"escapedValue\":\"&amp;cap;\",\"tooltip\":\"INTERSECTION\"},{\"name\":\"∪\",\"value\":\"∪\",\"escapedValue\":\"&amp;cup;\",\"tooltip\":\"UNION\"},{\"name\":\"∂\",\"value\":\"∂\",\"escapedValue\":\"&amp;part; &amp;PartialD;\",\"tooltip\":\"PARTIAL DIFFERENTIAL\"},{\"name\":\"∀\",\"value\":\"∀\",\"escapedValue\":\"&amp;forall; &amp;ForAll;\",\"tooltip\":\"FOR ALL\"},{\"name\":\"∃\",\"value\":\"∃\",\"escapedValue\":\"&amp;exist; &amp;Exists;\",\"tooltip\":\"THERE EXISTS\"},{\"name\":\"∅\",\"value\":\"∅\",\"escapedValue\":\"&amp;empty; &amp;emptyset; &amp;emptyv; &amp;varnothing;\",\"tooltip\":\"EMPTY SET\"},{\"name\":\"∇\",\"value\":\"∇\",\"escapedValue\":\"&amp;nabla; &amp;Del;\",\"tooltip\":\"NABLA\"},{\"name\":\"∗\",\"value\":\"∗\",\"escapedValue\":\"&amp;lowast;\",\"tooltip\":\"ASTERISK OPERATOR\"},{\"name\":\"∝\",\"value\":\"∝\",\"escapedValue\":\"&amp;prop; &amp;propto; &amp;Proportional; &amp;vprop; &amp;varpropto;\",\"tooltip\":\"PROPORTIONAL TO\"},{\"name\":\"∠\",\"value\":\"∠\",\"escapedValue\":\"&amp;ang; &amp;angle;\",\"tooltip\":\"ANGLE\"},{\"name\":\"ª\",\"value\":\"ª\",\"escapedValue\":\"&amp;ordf;\",\"tooltip\":\"FEMININE ORDINAL INDICATOR\"},{\"name\":\"º\",\"value\":\"º\",\"escapedValue\":\"&amp;ordm;\",\"tooltip\":\"MASCULINE ORDINAL INDICATOR\"},{\"name\":\"†\",\"value\":\"†\",\"escapedValue\":\"&amp;dagger;\",\"tooltip\":\"DAGGER\"},{\"name\":\"‡\",\"value\":\"‡\",\"escapedValue\":\"&amp;Dagger; &amp;ddagger;\",\"tooltip\":\"DOUBLE DAGGER\"},{\"name\":\"À\",\"value\":\"À\",\"escapedValue\":\"&amp;Agrave;\",\"tooltip\":\"LATIN CAPITAL LETTER A WITH GRAVE\"},{\"name\":\"Á\",\"value\":\"Á\",\"escapedValue\":\"&amp;Aacute;\",\"tooltip\":\"LATIN CAPITAL LETTER A WITH ACUTE\"},{\"name\":\"Â\",\"value\":\"Â\",\"escapedValue\":\"&amp;Acirc;\",\"tooltip\":\"LATIN CAPITAL LETTER A WITH CIRCUMFLEX\"},{\"name\":\"Ã\",\"value\":\"Ã\",\"escapedValue\":\"&amp;Atilde;\",\"tooltip\":\"LATIN CAPITAL LETTER A WITH TILDE\"},{\"name\":\"Ä\",\"value\":\"Ä\",\"escapedValue\":\"&amp;Auml;\",\"tooltip\":\"LATIN CAPITAL LETTER A WITH DIAERESIS\"},{\"name\":\"Å\",\"value\":\"Å\",\"escapedValue\":\"&amp;Aring;\",\"tooltip\":\"LATIN CAPITAL LETTER A WITH RING ABOVE\"},{\"name\":\"Æ\",\"value\":\"Æ\",\"escapedValue\":\"&amp;AElig;\",\"tooltip\":\"LATIN CAPITAL LETTER AE\"},{\"name\":\"Ç\",\"value\":\"Ç\",\"escapedValue\":\"&amp;Ccedil;\",\"tooltip\":\"LATIN CAPITAL LETTER C WITH CEDILLA\"},{\"name\":\"È\",\"value\":\"È\",\"escapedValue\":\"&amp;Egrave;\",\"tooltip\":\"LATIN CAPITAL LETTER E WITH GRAVE\"},{\"name\":\"É\",\"value\":\"É\",\"escapedValue\":\"&amp;Eacute;\",\"tooltip\":\"LATIN CAPITAL LETTER E WITH ACUTE\"},{\"name\":\"Ê\",\"value\":\"Ê\",\"escapedValue\":\"&amp;Ecirc;\",\"tooltip\":\"LATIN CAPITAL LETTER E WITH CIRCUMFLEX\"},{\"name\":\"Ë\",\"value\":\"Ë\",\"escapedValue\":\"&amp;Euml;\",\"tooltip\":\"LATIN CAPITAL LETTER E WITH DIAERESIS\"},{\"name\":\"Ì\",\"value\":\"Ì\",\"escapedValue\":\"&amp;Igrave;\",\"tooltip\":\"LATIN CAPITAL LETTER I WITH GRAVE\"},{\"name\":\"Í\",\"value\":\"Í\",\"escapedValue\":\"&amp;Iacute;\",\"tooltip\":\"LATIN CAPITAL LETTER I WITH ACUTE\"},{\"name\":\"Î\",\"value\":\"Î\",\"escapedValue\":\"&amp;Icirc;\",\"tooltip\":\"LATIN CAPITAL LETTER I WITH CIRCUMFLEX\"},{\"name\":\"Ï\",\"value\":\"Ï\",\"escapedValue\":\"&amp;Iuml;\",\"tooltip\":\"LATIN CAPITAL LETTER I WITH DIAERESIS\"},{\"name\":\"Ð\",\"value\":\"Ð\",\"escapedValue\":\"&amp;ETH;\",\"tooltip\":\"LATIN CAPITAL LETTER ETH\"},{\"name\":\"Ñ\",\"value\":\"Ñ\",\"escapedValue\":\"&amp;Ntilde;\",\"tooltip\":\"LATIN CAPITAL LETTER N WITH TILDE\"},{\"name\":\"Ò\",\"value\":\"Ò\",\"escapedValue\":\"&amp;Ograve;\",\"tooltip\":\"LATIN CAPITAL LETTER O WITH GRAVE\"},{\"name\":\"Ó\",\"value\":\"Ó\",\"escapedValue\":\"&amp;Oacute;\",\"tooltip\":\"LATIN CAPITAL LETTER O WITH ACUTE\"},{\"name\":\"Ô\",\"value\":\"Ô\",\"escapedValue\":\"&amp;Ocirc;\",\"tooltip\":\"LATIN CAPITAL LETTER O WITH CIRCUMFLEX\"},{\"name\":\"Õ\",\"value\":\"Õ\",\"escapedValue\":\"&amp;Otilde;\",\"tooltip\":\"LATIN CAPITAL LETTER O WITH TILDE\"},{\"name\":\"Ö\",\"value\":\"Ö\",\"escapedValue\":\"&amp;Ouml;\",\"tooltip\":\"LATIN CAPITAL LETTER O WITH DIAERESIS\"},{\"name\":\"Ø\",\"value\":\"Ø\",\"escapedValue\":\"&amp;Oslash;\",\"tooltip\":\"LATIN CAPITAL LETTER O WITH STROKE\"},{\"name\":\"Œ\",\"value\":\"Œ\",\"escapedValue\":\"&amp;OElig;\",\"tooltip\":\"LATIN CAPITAL LIGATURE OE\"},{\"name\":\"Š\",\"value\":\"Š\",\"escapedValue\":\"&amp;Scaron;\",\"tooltip\":\"LATIN CAPITAL LETTER S WITH CARON\"},{\"name\":\"Ù\",\"value\":\"Ù\",\"escapedValue\":\"&amp;Ugrave;\",\"tooltip\":\"LATIN CAPITAL LETTER U WITH GRAVE\"},{\"name\":\"Ú\",\"value\":\"Ú\",\"escapedValue\":\"&amp;Uacute;\",\"tooltip\":\"LATIN CAPITAL LETTER U WITH ACUTE\"},{\"name\":\"Û\",\"value\":\"Û\",\"escapedValue\":\"&amp;Ucirc;\",\"tooltip\":\"LATIN CAPITAL LETTER U WITH CIRCUMFLEX\"},{\"name\":\"Ü\",\"value\":\"Ü\",\"escapedValue\":\"&amp;Uuml;\",\"tooltip\":\"LATIN CAPITAL LETTER U WITH DIAERESIS\"},{\"name\":\"Ý\",\"value\":\"Ý\",\"escapedValue\":\"&amp;Yacute;\",\"tooltip\":\"LATIN CAPITAL LETTER Y WITH ACUTE\"},{\"name\":\"Ÿ\",\"value\":\"Ÿ\",\"escapedValue\":\"&amp;Yuml;\",\"tooltip\":\"LATIN CAPITAL LETTER Y WITH DIAERESIS\"},{\"name\":\"Þ\",\"value\":\"Þ\",\"escapedValue\":\"&amp;THORN;\",\"tooltip\":\"LATIN CAPITAL LETTER THORN\"},{\"name\":\"à\",\"value\":\"à\",\"escapedValue\":\"&amp;agrave;\",\"tooltip\":\"LATIN SMALL LETTER A WITH GRAVE\"},{\"name\":\"á\",\"value\":\"á\",\"escapedValue\":\"&amp;aacute;\",\"tooltip\":\"LATIN SMALL LETTER A WITH ACUTE\"},{\"name\":\"â\",\"value\":\"â\",\"escapedValue\":\"&amp;acirc;\",\"tooltip\":\"LATIN SMALL LETTER A WITH CIRCUMFLEX\"},{\"name\":\"ã\",\"value\":\"ã\",\"escapedValue\":\"&amp;atilde;\",\"tooltip\":\"LATIN SMALL LETTER A WITH TILDE\"},{\"name\":\"ä\",\"value\":\"ä\",\"escapedValue\":\"&amp;auml;\",\"tooltip\":\"LATIN SMALL LETTER A WITH DIAERESIS\"},{\"name\":\"å\",\"value\":\"å\",\"escapedValue\":\"&amp;aring;\",\"tooltip\":\"LATIN SMALL LETTER A WITH RING ABOVE\"},{\"name\":\"æ\",\"value\":\"æ\",\"escapedValue\":\"&amp;aelig;\",\"tooltip\":\"LATIN SMALL LETTER AE\"},{\"name\":\"ç\",\"value\":\"ç\",\"escapedValue\":\"&amp;ccedil;\",\"tooltip\":\"LATIN SMALL LETTER C WITH CEDILLA\"},{\"name\":\"è\",\"value\":\"è\",\"escapedValue\":\"&amp;egrave;\",\"tooltip\":\"LATIN SMALL LETTER E WITH GRAVE\"},{\"name\":\"é\",\"value\":\"é\",\"escapedValue\":\"&amp;eacute;\",\"tooltip\":\"LATIN SMALL LETTER E WITH ACUTE\"},{\"name\":\"ê\",\"value\":\"ê\",\"escapedValue\":\"&amp;ecirc;\",\"tooltip\":\"LATIN SMALL LETTER E WITH CIRCUMFLEX\"},{\"name\":\"ë\",\"value\":\"ë\",\"escapedValue\":\"&amp;euml;\",\"tooltip\":\"LATIN SMALL LETTER E WITH DIAERESIS\"},{\"name\":\"ì\",\"value\":\"ì\",\"escapedValue\":\"&amp;igrave;\",\"tooltip\":\"LATIN SMALL LETTER I WITH GRAVE\"},{\"name\":\"í\",\"value\":\"í\",\"escapedValue\":\"&amp;iacute;\",\"tooltip\":\"LATIN SMALL LETTER I WITH ACUTE\"},{\"name\":\"î\",\"value\":\"î\",\"escapedValue\":\"&amp;icirc;\",\"tooltip\":\"LATIN SMALL LETTER I WITH CIRCUMFLEX\"},{\"name\":\"ï\",\"value\":\"ï\",\"escapedValue\":\"&amp;iuml;\",\"tooltip\":\"LATIN SMALL LETTER I WITH DIAERESIS\"},{\"name\":\"ð\",\"value\":\"ð\",\"escapedValue\":\"&amp;eth;\",\"tooltip\":\"LATIN SMALL LETTER ETH\"},{\"name\":\"ñ\",\"value\":\"ñ\",\"escapedValue\":\"&amp;ntilde;\",\"tooltip\":\"LATIN SMALL LETTER N WITH TILDE\"},{\"name\":\"ò\",\"value\":\"ò\",\"escapedValue\":\"&amp;ograve;\",\"tooltip\":\"LATIN SMALL LETTER O WITH GRAVE\"},{\"name\":\"ó\",\"value\":\"ó\",\"escapedValue\":\"&amp;oacute;\",\"tooltip\":\"LATIN SMALL LETTER O WITH ACUTE\"},{\"name\":\"ô\",\"value\":\"ô\",\"escapedValue\":\"&amp;ocirc;\",\"tooltip\":\"LATIN SMALL LETTER O WITH CIRCUMFLEX\"},{\"name\":\"õ\",\"value\":\"õ\",\"escapedValue\":\"&amp;otilde;\",\"tooltip\":\"LATIN SMALL LETTER O WITH TILDE\"},{\"name\":\"ö\",\"value\":\"ö\",\"escapedValue\":\"&amp;ouml;\",\"tooltip\":\"LATIN SMALL LETTER O WITH DIAERESIS\"},{\"name\":\"ø\",\"value\":\"ø\",\"escapedValue\":\"&amp;oslash;\",\"tooltip\":\"LATIN SMALL LETTER O WITH STROKE\"},{\"name\":\"œ\",\"value\":\"œ\",\"escapedValue\":\"&amp;oelig;\",\"tooltip\":\"LATIN SMALL LIGATURE OE\"},{\"name\":\"š\",\"value\":\"š\",\"escapedValue\":\"&amp;scaron;\",\"tooltip\":\"LATIN SMALL LETTER S WITH CARON\"},{\"name\":\"ù\",\"value\":\"ù\",\"escapedValue\":\"&amp;ugrave;\",\"tooltip\":\"LATIN SMALL LETTER U WITH GRAVE\"},{\"name\":\"ú\",\"value\":\"ú\",\"escapedValue\":\"&amp;uacute;\",\"tooltip\":\"LATIN SMALL LETTER U WITH ACUTE\"},{\"name\":\"û\",\"value\":\"û\",\"escapedValue\":\"&amp;ucirc;\",\"tooltip\":\"LATIN SMALL LETTER U WITH CIRCUMFLEX\"},{\"name\":\"ü\",\"value\":\"ü\",\"escapedValue\":\"&amp;uuml;\",\"tooltip\":\"LATIN SMALL LETTER U WITH DIAERESIS\"},{\"name\":\"ý\",\"value\":\"ý\",\"escapedValue\":\"&amp;yacute;\",\"tooltip\":\"LATIN SMALL LETTER Y WITH ACUTE\"},{\"name\":\"þ\",\"value\":\"þ\",\"escapedValue\":\"&amp;thorn;\",\"tooltip\":\"LATIN SMALL LETTER THORN\"},{\"name\":\"ÿ\",\"value\":\"ÿ\",\"escapedValue\":\"&amp;yuml;\",\"tooltip\":\"LATIN SMALL LETTER Y WITH DIAERESIS\"},{\"name\":\"Α\",\"value\":\"Α\",\"escapedValue\":\"&amp;Alpha;\",\"tooltip\":\"GREEK CAPITAL LETTER ALPHA\"},{\"name\":\"Β\",\"value\":\"Β\",\"escapedValue\":\"&amp;Beta;\",\"tooltip\":\"GREEK CAPITAL LETTER BETA\"},{\"name\":\"Γ\",\"value\":\"Γ\",\"escapedValue\":\"&amp;Gamma;\",\"tooltip\":\"GREEK CAPITAL LETTER GAMMA\"},{\"name\":\"Ε\",\"value\":\"Ε\",\"escapedValue\":\"&amp;Epsilon;\",\"tooltip\":\"GREEK CAPITAL LETTER EPSILON\"},{\"name\":\"Ζ\",\"value\":\"Ζ\",\"escapedValue\":\"&amp;Zeta;\",\"tooltip\":\"GREEK CAPITAL LETTER ZETA\"},{\"name\":\"Η\",\"value\":\"Η\",\"escapedValue\":\"&amp;Eta;\",\"tooltip\":\"GREEK CAPITAL LETTER ETA\"},{\"name\":\"Θ\",\"value\":\"Θ\",\"escapedValue\":\"&amp;Theta;\",\"tooltip\":\"GREEK CAPITAL LETTER THETA\"},{\"name\":\"Ι\",\"value\":\"Ι\",\"escapedValue\":\"&amp;Iota;\",\"tooltip\":\"GREEK CAPITAL LETTER IOTA\"},{\"name\":\"Κ\",\"value\":\"Κ\",\"escapedValue\":\"&amp;Kappa;\",\"tooltip\":\"GREEK CAPITAL LETTER KAPPA\"},{\"name\":\"Λ\",\"value\":\"Λ\",\"escapedValue\":\"&amp;Lambda;\",\"tooltip\":\"GREEK CAPITAL LETTER LAMDA\"},{\"name\":\"Μ\",\"value\":\"Μ\",\"escapedValue\":\"&amp;Mu;\",\"tooltip\":\"GREEK CAPITAL LETTER MU\"},{\"name\":\"Ν\",\"value\":\"Ν\",\"escapedValue\":\"&amp;Nu;\",\"tooltip\":\"GREEK CAPITAL LETTER NU\"},{\"name\":\"Ξ\",\"value\":\"Ξ\",\"escapedValue\":\"&amp;Xi;\",\"tooltip\":\"GREEK CAPITAL LETTER XI\"},{\"name\":\"Ο\",\"value\":\"Ο\",\"escapedValue\":\"&amp;Omicron;\",\"tooltip\":\"GREEK CAPITAL LETTER OMICRON\"},{\"name\":\"Π\",\"value\":\"Π\",\"escapedValue\":\"&amp;Pi;\",\"tooltip\":\"GREEK CAPITAL LETTER PI\"},{\"name\":\"Ρ\",\"value\":\"Ρ\",\"escapedValue\":\"&amp;Rho;\",\"tooltip\":\"GREEK CAPITAL LETTER RHO\"},{\"name\":\"Σ\",\"value\":\"Σ\",\"escapedValue\":\"&amp;Sigma;\",\"tooltip\":\"GREEK CAPITAL LETTER SIGMA\"},{\"name\":\"Τ\",\"value\":\"Τ\",\"escapedValue\":\"&amp;Tau;\",\"tooltip\":\"GREEK CAPITAL LETTER TAU\"},{\"name\":\"Υ\",\"value\":\"Υ\",\"escapedValue\":\"&amp;Upsilon;\",\"tooltip\":\"GREEK CAPITAL LETTER UPSILON\"},{\"name\":\"Φ\",\"value\":\"Φ\",\"escapedValue\":\"&amp;Phi;\",\"tooltip\":\"GREEK CAPITAL LETTER PHI\"},{\"name\":\"Χ\",\"value\":\"Χ\",\"escapedValue\":\"&amp;Chi;\",\"tooltip\":\"GREEK CAPITAL LETTER CHI\"},{\"name\":\"Ψ\",\"value\":\"Ψ\",\"escapedValue\":\"&amp;Psi;\",\"tooltip\":\"GREEK CAPITAL LETTER PSI\"},{\"name\":\"Ω\",\"value\":\"Ω\",\"escapedValue\":\"&amp;Omega;\",\"tooltip\":\"GREEK CAPITAL LETTER OMEGA\"},{\"name\":\"α\",\"value\":\"α\",\"escapedValue\":\"&amp;alpha;\",\"tooltip\":\"GREEK SMALL LETTER ALPHA\"},{\"name\":\"β\",\"value\":\"β\",\"escapedValue\":\"&amp;beta;\",\"tooltip\":\"GREEK SMALL LETTER BETA\"},{\"name\":\"γ\",\"value\":\"γ\",\"escapedValue\":\"&amp;gamma;\",\"tooltip\":\"GREEK SMALL LETTER GAMMA\"},{\"name\":\"δ\",\"value\":\"δ\",\"escapedValue\":\"&amp;delta;\",\"tooltip\":\"GREEK SMALL LETTER DELTA\"},{\"name\":\"ε\",\"value\":\"ε\",\"escapedValue\":\"&amp;epsiv; &amp;varepsilon; &amp;epsilon;\",\"tooltip\":\"GREEK SMALL LETTER EPSILON\"},{\"name\":\"ζ\",\"value\":\"ζ\",\"escapedValue\":\"&amp;zeta;\",\"tooltip\":\"GREEK SMALL LETTER ZETA\"},{\"name\":\"η\",\"value\":\"η\",\"escapedValue\":\"&amp;eta;\",\"tooltip\":\"GREEK SMALL LETTER ETA\"},{\"name\":\"θ\",\"value\":\"θ\",\"escapedValue\":\"&amp;theta;\",\"tooltip\":\"GREEK SMALL LETTER THETA\"},{\"name\":\"ι\",\"value\":\"ι\",\"escapedValue\":\"&amp;iota;\",\"tooltip\":\"GREEK SMALL LETTER IOTA\"},{\"name\":\"κ\",\"value\":\"κ\",\"escapedValue\":\"&amp;kappa;\",\"tooltip\":\"GREEK SMALL LETTER KAPPA\"},{\"name\":\"λ\",\"value\":\"λ\",\"escapedValue\":\"&amp;lambda;\",\"tooltip\":\"GREEK SMALL LETTER LAMDA\"},{\"name\":\"μ\",\"value\":\"μ\",\"escapedValue\":\"&amp;mu;\",\"tooltip\":\"GREEK SMALL LETTER MU\"},{\"name\":\"ν\",\"value\":\"ν\",\"escapedValue\":\"&amp;nu;\",\"tooltip\":\"GREEK SMALL LETTER NU\"},{\"name\":\"ξ\",\"value\":\"ξ\",\"escapedValue\":\"&amp;xi;\",\"tooltip\":\"GREEK SMALL LETTER XI\"},{\"name\":\"ο\",\"value\":\"ο\",\"escapedValue\":\"&amp;omicron;\",\"tooltip\":\"GREEK SMALL LETTER OMICRON\"},{\"name\":\"π\",\"value\":\"π\",\"escapedValue\":\"&amp;pi;\",\"tooltip\":\"GREEK SMALL LETTER PI\"},{\"name\":\"ρ\",\"value\":\"ρ\",\"escapedValue\":\"&amp;rho;\",\"tooltip\":\"GREEK SMALL LETTER RHO\"},{\"name\":\"ς\",\"value\":\"ς\",\"escapedValue\":\"&amp;sigmav; &amp;varsigma; &amp;sigmaf;\",\"tooltip\":\"GREEK SMALL LETTER FINAL SIGMA\"},{\"name\":\"σ\",\"value\":\"σ\",\"escapedValue\":\"&amp;sigma;\",\"tooltip\":\"GREEK SMALL LETTER SIGMA\"},{\"name\":\"τ\",\"value\":\"τ\",\"escapedValue\":\"&amp;tau;\",\"tooltip\":\"GREEK SMALL LETTER TAU\"},{\"name\":\"υ\",\"value\":\"υ\",\"escapedValue\":\"&amp;upsi; &amp;upsilon;\",\"tooltip\":\"GREEK SMALL LETTER UPSILON\"},{\"name\":\"φ\",\"value\":\"φ\",\"escapedValue\":\"&amp;phi; &amp;phiv; &amp;varphi;\",\"tooltip\":\"GREEK SMALL LETTER PHI\"},{\"name\":\"χ\",\"value\":\"χ\",\"escapedValue\":\"&amp;chi;\",\"tooltip\":\"GREEK SMALL LETTER CHI\"},{\"name\":\"ψ\",\"value\":\"ψ\",\"escapedValue\":\"&amp;psi;\",\"tooltip\":\"GREEK SMALL LETTER PSI\"},{\"name\":\"ω\",\"value\":\"ω\",\"escapedValue\":\"&amp;omega;\",\"tooltip\":\"GREEK SMALL LETTER OMEGA\"},{\"name\":\"←\",\"value\":\"←\",\"escapedValue\":\"&amp;larr; &amp;leftarrow; &amp;LeftArrow; &amp;slarr; &amp;ShortLeftArrow;\",\"tooltip\":\"LEFTWARDS ARROW\"},{\"name\":\"↑\",\"value\":\"↑\",\"escapedValue\":\"&amp;uarr; &amp;uparrow; &amp;UpArrow; &amp;ShortUpArrow;\",\"tooltip\":\"UPWARDS ARROW\"},{\"name\":\"→\",\"value\":\"→\",\"escapedValue\":\"&amp;rarr; &amp;rightarrow; &amp;RightArrow; &amp;srarr; &amp;ShortRightArrow;\",\"tooltip\":\"RIGHTWARDS ARROW\"},{\"name\":\"↓\",\"value\":\"↓\",\"escapedValue\":\"&amp;darr; &amp;downarrow; &amp;DownArrow; &amp;ShortDownArrow;\",\"tooltip\":\"DOWNWARDS ARROW\"},{\"name\":\"↔\",\"value\":\"↔\",\"escapedValue\":\"&amp;harr; &amp;leftrightarrow; &amp;LeftRightArrow;\",\"tooltip\":\"LEFT RIGHT ARROW\"},{\"name\":\"↵\",\"value\":\"↵\",\"escapedValue\":\"&amp;crarr;\",\"tooltip\":\"DOWNWARDS ARROW WITH CORNER LEFTWARDS\"},{\"name\":\"⇐\",\"value\":\"⇐\",\"escapedValue\":\"&amp;lArr; &amp;Leftarrow; &amp;DoubleLeftArrow;\",\"tooltip\":\"LEFTWARDS DOUBLE ARROW\"},{\"name\":\"⇑\",\"value\":\"⇑\",\"escapedValue\":\"&amp;uArr; &amp;Uparrow; &amp;DoubleUpArrow;\",\"tooltip\":\"UPWARDS DOUBLE ARROW\"},{\"name\":\"⇒\",\"value\":\"⇒\",\"escapedValue\":\"&amp;rArr; &amp;Rightarrow; &amp;Implies; &amp;DoubleRightArrow;\",\"tooltip\":\"RIGHTWARDS DOUBLE ARROW\"},{\"name\":\"⇓\",\"value\":\"⇓\",\"escapedValue\":\"&amp;dArr; &amp;Downarrow; &amp;DoubleDownArrow;\",\"tooltip\":\"DOWNWARDS DOUBLE ARROW\"},{\"name\":\"⇔\",\"value\":\"⇔\",\"escapedValue\":\"&amp;hArr; &amp;Leftrightarrow; &amp;DoubleLeftRightArrow; &amp;iff;\",\"tooltip\":\"LEFT RIGHT DOUBLE ARROW\"},{\"name\":\"∴\",\"value\":\"∴\",\"escapedValue\":\"&amp;there4; &amp;therefore; &amp;Therefore;\",\"tooltip\":\"THEREFORE\"},{\"name\":\"⊂\",\"value\":\"⊂\",\"escapedValue\":\"&amp;sub; &amp;subset;\",\"tooltip\":\"SUBSET OF\"},{\"name\":\"⊃\",\"value\":\"⊃\",\"escapedValue\":\"&amp;sup; &amp;supset; &amp;Superset;\",\"tooltip\":\"SUPERSET OF\"},{\"name\":\"⊄\",\"value\":\"⊄\",\"escapedValue\":\"&amp;nsub;\",\"tooltip\":\"NOT A SUBSET OF\"},{\"name\":\"⊆\",\"value\":\"⊆\",\"escapedValue\":\"&amp;sube; &amp;SubsetEqual; &amp;subseteq;\",\"tooltip\":\"SUBSET OF OR EQUAL TO\"},{\"name\":\"⊇\",\"value\":\"⊇\",\"escapedValue\":\"&amp;supe; &amp;supseteq; &amp;SupersetEqual;\",\"tooltip\":\"SUPERSET OF OR EQUAL TO\"},{\"name\":\"⊕\",\"value\":\"⊕\",\"escapedValue\":\"&amp;oplus; &amp;CirclePlus;\",\"tooltip\":\"CIRCLED PLUS\"},{\"name\":\"⊗\",\"value\":\"⊗\",\"escapedValue\":\"&amp;otimes; &amp;CircleTimes;\",\"tooltip\":\"CIRCLED TIMES\"},{\"name\":\"⊥\",\"value\":\"⊥\",\"escapedValue\":\"&amp;bottom; &amp;bot; &amp;perp; &amp;UpTee;\",\"tooltip\":\"UP TACK\"},{\"name\":\"⌈\",\"value\":\"⌈\",\"escapedValue\":\"&amp;lceil; &amp;LeftCeiling;\",\"tooltip\":\"LEFT CEILING\"},{\"name\":\"⌉\",\"value\":\"⌉\",\"escapedValue\":\"&amp;rceil; &amp;RightCeiling;\",\"tooltip\":\"RIGHT CEILING\"},{\"name\":\"⌊\",\"value\":\"⌊\",\"escapedValue\":\"&amp;lfloor; &amp;LeftFloor;\",\"tooltip\":\"LEFT FLOOR\"},{\"name\":\"⌋\",\"value\":\"⌋\",\"escapedValue\":\"&amp;rfloor; &amp;RightFloor;\",\"tooltip\":\"RIGHT FLOOR\"},{\"name\":\"⟨\",\"value\":\"⟨\",\"escapedValue\":\"&amp;lang; &amp;LeftAngleBracket; &amp;langle;\",\"tooltip\":\"MATHEMATICAL LEFT ANGLE BRACKET\"},{\"name\":\"⟩\",\"value\":\"⟩\",\"escapedValue\":\"&amp;rang; &amp;RightAngleBracket; &amp;rangle;\",\"tooltip\":\"MATHEMATICAL RIGHT ANGLE BRACKET\"}]");

/***/ }),

/***/ "ext_mod_id_1649152171063_27":
/*!***************************************************************************!*\
  !*** ./src/editor-extender/spell-check/edit-menu-spell-check-provider.ts ***!
  \***************************************************************************/
/*! exports provided: EDIT_MENU_SPELL_CHECK_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EDIT_MENU_SPELL_CHECK_PROVIDER", function() { return EDIT_MENU_SPELL_CHECK_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



var EditMenuSpellCheckProvider = /** @class */ (function () {
    function EditMenuSpellCheckProvider() {
    }
    EditMenuSpellCheckProvider.prototype.getButtons = function (element) {
        if (element instanceof HTMLSpanElement && element.attributes["suggestion"]) {
            var spellCheckButtons = this.createSpellCheckButtons(element);
            return spellCheckButtons;
        }
        return [];
    };
    EditMenuSpellCheckProvider.prototype.createSpellCheckButtons = function (element) {
        var suggestion = element.attributes["suggestion"].value;
        var fakeWordButton = {
            name: "suggestion",
            action: null,
            text: "" + suggestion,
            tooltip: "" + suggestion,
            isActive: false,
            closeMenuOnClick: false
        };
        var acceptButton = {
            name: "check",
            action: function () {
                element.outerHTML = suggestion;
            },
            text: null,
            tooltip: "Accept correction",
            isActive: false,
            closeMenuOnClick: true
        };
        var cancelButton = {
            name: "times",
            action: function () {
                element.outerHTML = element.innerText;
            },
            text: null,
            tooltip: "Discard",
            isActive: false,
            closeMenuOnClick: true
        };
        return [
            new _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EditMenuSection"](fakeWordButton),
            new _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EditMenuSection"](acceptButton),
            new _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EditMenuSection"](cancelButton)
        ];
    };
    EditMenuSpellCheckProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
    ], EditMenuSpellCheckProvider);
    return EditMenuSpellCheckProvider;
}());
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
var EDIT_MENU_SPELL_CHECK_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EDIT_MENU_TOKEN"],
    useClass: EditMenuSpellCheckProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_28":
/*!************************************************************************!*\
  !*** ./src/editor-extender/spell-check/editor-spell-check-provider.ts ***!
  \************************************************************************/
/*! exports provided: EDITOR_SPELL_CHECK_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "EDITOR_SPELL_CHECK_PROVIDER", function() { return EDITOR_SPELL_CHECK_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "ext_mod_id_1649152171063_29");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_common_http__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1649152171063_17");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_4__);





// This is webpack specific loader syntax for injecting css as <style> tag in header
__webpack_require__(/*! style-loader!css-loader!./editor-spell-check-provider.css */ "ext_mod_id_1649152171063_30");
/*
 * NOTE: Replace this example key with your subscription key.
 * For more information on how to get a key check here: https://azure.microsoft.com/en-us/services/cognitive-services/spell-check/
 */
var AZURE_LANGUAGE_SERVICES_API_KEY = "";
/**
 * Indicates the minimum value of certainty that is needed in order a correction to be applied.
 */
var MIN_CERTAINTY = 0.5;
var HOST = "https://api.cognitive.microsoft.com";
var PATH = "/bing/v7.0/spellcheck";
/**
 * Mode of spellcheck
 * Proof - Meant to provide Office Word like spelling corrections.
 *         It can correct long queries, provide casing corrections and suppresses aggressive corrections.
 * Spell - Meant to provide Search engine like spelling corrections.
 *         It will correct small queries(up to length 65 tokens) without any casing changes and
 *         will be more optimized (perf and relevance) towards search like queries.
 */
var PROOF_MODE = "proof";
var SPELL_MODE = "spell";
/**
 * Currently the proof mode supports only these 3 cultures. For other cultures spell mode should be used.
 * The list is subject to change.
 * For more information check: https://docs.microsoft.com/bg-bg/azure/cognitive-services/bing-spell-check/proof-text
 */
var proofModeCultures = [
    "en-US",
    "es-ES",
    "pt-BR"
];
/**
 * A custom toolbar provider implementation for checheking and correcting the spelling in the kendo editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
var EditorSpellCheckProvider = /** @class */ (function () {
    function EditorSpellCheckProvider(http) {
        this.http = http;
    }
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     * @param editorHost The instance of the editor.
     */
    EditorSpellCheckProvider.prototype.getToolBarItems = function (editorHost) {
        var _this = this;
        var SPELL_CHECK_TOOLBAR_ITEM = {
            name: "Spell-check",
            tooltip: "Spell check",
            ordinal: -1,
            exec: function () { return _this.spellCheck(editorHost, _this.culture); }
        };
        return [SPELL_CHECK_TOOLBAR_ITEM];
    };
    EditorSpellCheckProvider.prototype.getToolBarItemsNamesToRemove = function () {
        /**
         * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
         * Otherwise return an empty array.
         * Example: return [ "embed" ];
         * The above code will remove the embed toolbar item from the editor.
         * Documentation where you can find all tools' names: https://docs.telerik.com/kendo-ui/api/javascript/ui/editor/configuration/tools
         */
        return [];
    };
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration Overiview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     */
    EditorSpellCheckProvider.prototype.configureEditor = function (configuration) {
        this.culture = configuration.culture;
        return configuration;
    };
    EditorSpellCheckProvider.prototype.spellCheck = function (editorHost, culture) {
        var _this = this;
        var editor = editorHost.getKendoEditor();
        var text = editor.value();
        var textWithoutHTMLTags = this.stripHTML(text);
        var batches = [{
                text: textWithoutHTMLTags,
                startIndex: 0
            }];
        var mode = PROOF_MODE;
        /*
        * NOTE: Spell mode will make a batch of queries.
        * There is a change your subscription plan does not support multiple queries per second.
        * In such case use proof mode.
        */
        if (culture && proofModeCultures.indexOf(culture) === -1) {
            mode = SPELL_MODE;
            batches = this.splitTextInBatches(textWithoutHTMLTags);
        }
        var requests = [];
        batches.forEach(function (batch) {
            requests.push(_this.makeRequest(batch.text, culture, mode));
        });
        Object(rxjs__WEBPACK_IMPORTED_MODULE_4__["forkJoin"])(requests).subscribe(function (responses) {
            var lastMarkedErrorIndex = 0;
            responses.forEach(function (response, index) {
                if (response._type === "SpellCheck") {
                    response.flaggedTokens.forEach(function (token) {
                        // find the token in the text
                        var indexOfMisspelledWord = text.indexOf(token.token, lastMarkedErrorIndex);
                        if (indexOfMisspelledWord < token.offset + batches[index].startIndex)
                            return;
                        if (token.suggestions.length <= 0)
                            return;
                        // get the best suggestion if over the min required certainty
                        var suggestion = token.suggestions[0].suggestion;
                        var certainty = token.suggestions[0].score;
                        if (certainty < MIN_CERTAINTY)
                            return;
                        var markedWord = document.createElement("SPAN");
                        markedWord.setAttribute("suggestion", suggestion);
                        markedWord.setAttribute("data-sf-ec-immutable", "");
                        markedWord.setAttribute("custom-edit-menu", "");
                        markedWord.innerText = token.token;
                        // check if word is already marked
                        var indexOfMarkedWord = text.indexOf(markedWord.outerHTML, lastMarkedErrorIndex);
                        if (indexOfMarkedWord !== -1 && indexOfMarkedWord < indexOfMisspelledWord)
                            return;
                        // apply the mark
                        text = text.slice(0, indexOfMisspelledWord)
                            + text.slice(indexOfMisspelledWord, indexOfMisspelledWord + token.token.length).replace(token.token, markedWord.outerHTML)
                            + text.slice(indexOfMisspelledWord + token.token.length);
                        // bump the counter of fixed words
                        lastMarkedErrorIndex = indexOfMisspelledWord + markedWord.outerHTML.length;
                    });
                    editor.value(text);
                    editor.trigger("change");
                }
            });
        }, function (error) {
            alert(error.error.message + " Contact your administrator to resolve this issue.");
        });
    };
    EditorSpellCheckProvider.prototype.makeRequest = function (text, culture, mode) {
        if (culture === void 0) { culture = "en-US"; }
        if (mode === void 0) { mode = "proof"; }
        var queryString = "?mkt=" + culture + "&mode=" + mode;
        var url = HOST + PATH + queryString;
        var body = new URLSearchParams();
        body.set("text", text);
        var options = {
            headers: {
                "Ocp-Apim-Subscription-Key": AZURE_LANGUAGE_SERVICES_API_KEY,
                "Content-Type": "application/x-www-form-urlencoded"
            }
        };
        return this.http.post(url, body.toString(), options);
    };
    EditorSpellCheckProvider.prototype.stripHTML = function (html) {
        var tmp = document.createElement("DIV");
        tmp.innerHTML = html;
        return tmp.textContent || tmp.innerText || "";
    };
    EditorSpellCheckProvider.prototype.splitTextInBatches = function (text) {
        var batches = [];
        var words = text.split(" ");
        var batch = {
            text: "",
            startIndex: 0
        };
        var lastMarkedBatchIndex = 0;
        words.forEach(function (word) {
            var newBatchText = batch.text === "" ? word : batch.text + " " + word;
            if (newBatchText.length <= 65) {
                batch.text = newBatchText;
            }
            else {
                // find the batch in the text
                var indexOfBatch = text.indexOf(batch.text, lastMarkedBatchIndex);
                batch.startIndex = indexOfBatch;
                lastMarkedBatchIndex = indexOfBatch;
                batches.push(JSON.parse(JSON.stringify(batch)));
                batch.text = word;
            }
        });
        batches.push(batch);
        return batches;
    };
    EditorSpellCheckProvider.ctorParameters = function () { return [
        { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClient"] }
    ]; };
    EditorSpellCheckProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"])("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_3__["HttpClient"]])
    ], EditorSpellCheckProvider);
    return EditorSpellCheckProvider;
}());
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
var EDITOR_SPELL_CHECK_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EDITOR_CONFIG_TOKEN"],
    useClass: EditorSpellCheckProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_29":
/*!**********************************************************************************************************!*\
  !*** delegated ./node_modules/@angular/common/__ivy_ngcc__/fesm2015/http.js from dll-reference adminapp ***!
  \**********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/@angular/common/__ivy_ngcc__/fesm2015/http.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_3":
/*!*******************************************************************************!*\
  !*** delegated ./node_modules/tslib/tslib.es6.js from dll-reference adminapp ***!
  \*******************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/tslib/tslib.es6.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_30":
/*!*******************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./src/editor-extender/spell-check/editor-spell-check-provider.css ***!
  \*******************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var api = __webpack_require__(/*! ../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1649152171063_10");
            var content = __webpack_require__(/*! !../../../node_modules/css-loader/dist/cjs.js!./editor-spell-check-provider.css */ "ext_mod_id_1649152171063_31");

            content = content.__esModule ? content.default : content;

            if (typeof content === 'string') {
              content = [[module.i, content, '']];
            }

var options = {};

options.insert = "head";
options.singleton = false;

var update = api(content, options);



module.exports = content.locals || {};

/***/ }),

/***/ "ext_mod_id_1649152171063_31":
/*!***************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./src/editor-extender/spell-check/editor-spell-check-provider.css ***!
  \***************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Imports
var ___CSS_LOADER_API_IMPORT___ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1649152171063_12");
exports = ___CSS_LOADER_API_IMPORT___(false);
// Module
exports.push([module.i, ".k-editor-toolbar .k-i-Spell-correction::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e13c\";\r\n}\r\n\r\n.k-editor-toolbar .k-i-Spell-check::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e68d\";\r\n}\r\n\r\nspan[suggestion] {\r\n    background-color: yellow;\r\n}\r\n", ""]);
// Exports
module.exports = exports;


/***/ }),

/***/ "ext_mod_id_1649152171063_32":
/*!******************************************************************************************!*\
  !*** ./src/editor-extender/sitefinity-images/sitefinity-images-toolbar-item-provider.ts ***!
  \******************************************************************************************/
/*! exports provided: ensureTrailingBreaks, IMAGE_TOOLBAR_ITEM_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ensureTrailingBreaks", function() { return ensureTrailingBreaks; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "IMAGE_TOOLBAR_ITEM_PROVIDER", function() { return IMAGE_TOOLBAR_ITEM_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



var TRAILING_BREAK = "<br class='k-br'>";
__webpack_require__(/*! style-loader!css-loader!./sitefinity-images-toolbar-item-provider.css */ "ext_mod_id_1649152171063_33");
var ensureTrailingBreaks = function (html) {
    return "" + TRAILING_BREAK + html + TRAILING_BREAK;
};
/**
 * A custom toolbar provider implementation for inserting existing images in the editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
var ImagesToolbarItemProvider = /** @class */ (function () {
    function ImagesToolbarItemProvider(selectorService) {
        this.selectorService = selectorService;
    }
    ImagesToolbarItemProvider.prototype.getToolBarItems = function (editorHost) {
        var _this = this;
        var CUSTOM_TOOLBAR_ITEM = {
            name: "Sitefinity-images",
            tooltip: "Sitefinity images",
            ordinal: 7,
            exec: function () {
                var editor = editorHost.getKendoEditor();
                // Save editor's current range, so we can insert
                // later the HTML at this position.
                var currentRange = editor.getRange();
                var selectorOptions = {
                    multiple: true
                };
                // open the selector and subscribe to the result
                _this.selectorService.openImageLibrarySelector(selectorOptions).subscribe(function (images) {
                    if (images.length) {
                        // Restore editor's saved position.
                        editor.selectRange(currentRange);
                        images.forEach(function (img) {
                            var imageElement = document.createElement("img");
                            imageElement.src = img.data.ThumbnailUrl;
                            // Insert the HTML and trigger editor's change, so the
                            // HTML can be saved.
                            editor.paste(ensureTrailingBreaks(imageElement.outerHTML));
                            editor.trigger("change");
                        });
                    }
                });
            }
        };
        return [CUSTOM_TOOLBAR_ITEM];
    };
    ImagesToolbarItemProvider.prototype.getToolBarItemsNamesToRemove = function () {
        // If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
        // Otherwise return an empty array.
        // Example: return [ "embed" ];
        // The above code will remove the embed toolbar item from the editor.
        return [];
    };
    ImagesToolbarItemProvider.ctorParameters = function () { return [
        { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__["Inject"], args: [_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["SELECTOR_SERVICE"],] }] }
    ]; };
    ImagesToolbarItemProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])(),
        Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__metadata"])("design:paramtypes", [Object])
    ], ImagesToolbarItemProvider);
    return ImagesToolbarItemProvider;
}());
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
var IMAGE_TOOLBAR_ITEM_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["TOOLBARITEMS_TOKEN"],
    useClass: ImagesToolbarItemProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_33":
/*!*************************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./src/editor-extender/sitefinity-images/sitefinity-images-toolbar-item-provider.css ***!
  \*************************************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var api = __webpack_require__(/*! ../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1649152171063_10");
            var content = __webpack_require__(/*! !../../../node_modules/css-loader/dist/cjs.js!./sitefinity-images-toolbar-item-provider.css */ "ext_mod_id_1649152171063_34");

            content = content.__esModule ? content.default : content;

            if (typeof content === 'string') {
              content = [[module.i, content, '']];
            }

var options = {};

options.insert = "head";
options.singleton = false;

var update = api(content, options);



module.exports = content.locals || {};

/***/ }),

/***/ "ext_mod_id_1649152171063_34":
/*!*********************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./src/editor-extender/sitefinity-images/sitefinity-images-toolbar-item-provider.css ***!
  \*********************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

// Imports
var ___CSS_LOADER_API_IMPORT___ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1649152171063_12");
exports = ___CSS_LOADER_API_IMPORT___(false);
// Module
exports.push([module.i, ".k-editor-toolbar .k-i-Sitefinity-images::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e654\";\r\n}\r\n", ""]);
// Exports
module.exports = exports;


/***/ }),

/***/ "ext_mod_id_1649152171063_4":
/*!***************************!*\
  !*** external "adminapp" ***!
  \***************************/
/*! no static exports found */
/***/ (function(module, exports) {

module.exports = adminapp;

/***/ }),

/***/ "ext_mod_id_1649152171063_5":
/*!********************************************************************************************************!*\
  !*** delegated ./node_modules/@angular/core/__ivy_ngcc__/fesm2015/core.js from dll-reference adminapp ***!
  \********************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/@angular/core/__ivy_ngcc__/fesm2015/core.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_6":
/*!************************************************************************************************************!*\
  !*** delegated ./node_modules/@angular/common/__ivy_ngcc__/fesm2015/common.js from dll-reference adminapp ***!
  \************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/@angular/common/__ivy_ngcc__/fesm2015/common.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_7":
/*!***************************************************************!*\
  !*** ./src/editor-extender/word-count/word-count-provider.ts ***!
  \***************************************************************/
/*! exports provided: WORD_COUNT_PROVIDER */
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "WORD_COUNT_PROVIDER", function() { return WORD_COUNT_PROVIDER; });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1649152171063_3");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1649152171063_5");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1649152171063_8");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



// This is webpack specific loader syntax for injecting css as <style> tag in header
__webpack_require__(/*! style-loader!css-loader!./editor-config-provider.css */ "ext_mod_id_1649152171063_9");
/**
 * A custom toolbar provider implementation for counting the words in the html editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
var WordCountProvider = /** @class */ (function () {
    function WordCountProvider() {
    }
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     * @param editorHost The instance of the editor.
     */
    WordCountProvider.prototype.getToolBarItems = function (editorHost) {
        var _this = this;
        var wordsCount = function () {
            var editor = editorHost.getKendoEditor();
            var editorValue = _this.stripHTML(editor.value());
            var count = editorValue ? editorValue.split(" ").length : 0;
            alert("Words count: " + count);
        };
        /**
         * A custom toolbar item
         */
        var CUSTOM_TOOLBAR_ITEM = {
            name: "Words-count",
            tooltip: "Words count",
            ordinal: 5,
            exec: wordsCount
        };
        return [CUSTOM_TOOLBAR_ITEM];
    };
    WordCountProvider.prototype.getToolBarItemsNamesToRemove = function () {
        /**
         * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
         * Otherwise return an empty array.
         * Example: return [ "embed" ];
         * The above code will remove the embed toolbar item from the editor.
         * Documentation where you can find all tools' names: https://docs.telerik.com/kendo-ui/api/javascript/ui/editor/configuration/tools
         */
        return [];
    };
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration overview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     */
    WordCountProvider.prototype.configureEditor = function (configuration) {
        configuration.pasteCleanup.span = false;
        return configuration;
    };
    WordCountProvider.prototype.stripHTML = function (html) {
        var tmp = document.createElement("DIV");
        tmp.innerHTML = html;
        return tmp.textContent || tmp.innerText || "";
    };
    WordCountProvider = Object(tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"])([
        Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])()
    ], WordCountProvider);
    return WordCountProvider;
}());
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
var WORD_COUNT_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__["EDITOR_CONFIG_TOKEN"],
    useClass: WordCountProvider
};


/***/ }),

/***/ "ext_mod_id_1649152171063_8":
/*!******************************************************************************************************************!*\
  !*** delegated ./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/index.js from dll-reference adminapp ***!
  \******************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

module.exports = __iris_require__('./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/index.js')

/***/ }),

/***/ "ext_mod_id_1649152171063_9":
/*!*************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./src/editor-extender/word-count/editor-config-provider.css ***!
  \*************************************************************************************************************************************************/
/*! no static exports found */
/***/ (function(module, exports, __webpack_require__) {

var api = __webpack_require__(/*! ../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1649152171063_10");
            var content = __webpack_require__(/*! !../../../node_modules/css-loader/dist/cjs.js!./editor-config-provider.css */ "ext_mod_id_1649152171063_11");

            content = content.__esModule ? content.default : content;

            if (typeof content === 'string') {
              content = [[module.i, content, '']];
            }

var options = {};

options.insert = "head";
options.singleton = false;

var update = api(content, options);



module.exports = content.locals || {};

/***/ })

},[["ext_mod_id_1649152171063_1","runtime"]]]);
//# sourceMappingURL=editor.extensions.bundle.js.map