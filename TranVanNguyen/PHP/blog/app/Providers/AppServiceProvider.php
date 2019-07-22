<?php

namespace App\Providers;

use Illuminate\Support\ServiceProvider;
use Schema;
use Illuminate\Support\Facades\View;
use App\Tag;
use App\Category;

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
        $lsCate = Category::all();
        $lsTag = Tag::all();
        View::share('lsCate', $lsCate);
        View::share('lsTag', $lsTag);
		Schema::defaultStringLength(191);
    }

}
