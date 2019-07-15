<?php

namespace App\Providers;

use Illuminate\Support\ServiceProvider;
use Schema;
use Illuminate\Support\Facades\View;
use App\Category;
use App\Tag;

class AppServiceProvider extends ServiceProvider
{
    /**
     * Register any application services.
     *
     * @return void
     */
    public function register()
    {
        //
    }

    /**
     * Bootstrap any application services.
     *
     * @return void
     */
    public function boot()
    {
        $lsCategory = Category::all();
        $lsTag = Tag::all();
        View::share('lsCategory', $lsCategory);
        View::share('lsTag', $lsTag);
		    Schema::defaultStringLength(191);
    }
}
