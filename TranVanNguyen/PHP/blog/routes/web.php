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

Route::get('/', 'HomepageController@index');

Route::get('/view_post/{id}', 'HomepageController@view_post');

Route::get('/view_post_tag/{id}', 'HomepageController@view_post_tag');

Route::get('/view_post_cate/{id}', 'HomepageController@view_post_cate');

Route::get('/contact.html', function () {
    return view('contact');
});
Route::post('post_comment/{id}', 'CommentController@post_comment');
Route::post("post_comment_ajax/{id}", "CommentController@post_comment_ajax");

Auth::routes();


Route::group(['middleware' => 'auth'], function(){
    Route::get('/home', 'HomeController@index')->name('home');
    Route::resource('/category', 'CategoryController');
    Route::resource('/tag', 'TagController');
    Route::resource('/post', 'PostController');
    Route::get('/comment', 'CommentController@comment');
    Route::post('/change_comment_status_ajax', 'CommentController@change_comment_status_ajax');
    Route::post('/change_post_status_ajax', 'PostController@change_post_status_ajax');
});

