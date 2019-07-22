@extends("layouts.app")
@section("content")
<form enctype="multipart/form-data" method="POST" action="{{route('post.store')}}">
  @csrf
    Title: <input type="text" name="title" />
    <br/>
    Cover: <input type="file" name="cover" />
    <br/>
    Content: <textarea name="content1" id="content1"></textarea>
    <br/>
    Category: 
    <select name="category[]" multiple>
        @foreach ($lsCate as $cate)
          <option value="{{$cate->id}}">{{$cate->name}}</option>
        @endforeach
    </select>

    <br/>
    Tag: 
    <select name="tag[]" multiple>
        @foreach ($lsTag as $tag)
          <option value="{{$tag->id}}">{{$tag->name}}</option>
        @endforeach
    </select>
    <br/>

    <input type="submit" class="btn btn-info" value="ADD">
  </form>

@endsection
