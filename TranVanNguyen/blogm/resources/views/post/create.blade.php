@extends('layouts.app')
@section('content')

<form action="">
    Title: 
    <input type="text" name="title">
    Content:
    <textarea name="content" id="" cols="30" rows="10"></textarea>
</form>


@endsection

<script src="{{asset('/vendor/unisharp/laravel-ckeditor/ckeditor.js')}}"></script>
{{-- <script src="{{asset('/vendor/unisharp/laravel-ckeditor/adapters/jquery.js')}}"></script> --}}
<script>
    CKEDITOR.replace('content');
</script>