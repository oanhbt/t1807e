<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', 'HomePageController@index');
Route::get('/view_post/{id}', 'HomePageController@view_post');
Route::get('/view_category/{id}', 'HomePageController@view_category');
Route::get('/view_tag/{id}', 'HomePageController@view_tag');

Route::get('/contact.html', function () {
    return view('contact');
});

Route::post('/post_comment/{id}', 'CommentController@post_comment');
Route::post("post_comment_ajax/{id}", "CommentController@post_comment_ajax");
Route::get('view_post_{id}.html', 'HomePageController@view_post');

Auth::routes();

Route::group(['middleware' => 'auth'], function () {
  Route::get('/home', 'HomeController@index')->name('home');
  Route::resource('/category', 'CategoryController');
  Route::resource('/tag', 'TagController');
  Route::resource('/post', 'PostController');
});
