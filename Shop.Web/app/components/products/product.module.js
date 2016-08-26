﻿/// <reference path="/Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('shop.products', ['shop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('products', {
                url: "/products",
                templateUrl: "/app/components/products/productListView.html",
                controller: "productController"
        }).state('product_add', {
            url: "/product_add",
            templateUrl: "/app/components/products/productAddView.html",
            controller: "productController"
        });;
        }
})();