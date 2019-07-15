@extends("layouts.app")
@section("content")

<div class="container">
  <form enctype="multipart/form-data"
  method="POST"
  action="{{route('post.store')}}"
  accept-charset="UTF-8">
    @csrf
    Title: <input type="text" name="title" />
    <br/>

    Cover: <input type="file" name="cover" />
    <br/>

    Content <textarea name="content" id="content"></textarea>

    <br/>
    Category:
    <select name="category[]" multiple>
      @foreach($lsCate as $cate)
        <option value="{{$cate->id}}">{{$cate->name}}</option>
      @endforeach
    </select>
    <br/>
    Tag:
    <select name="tag[]" multiple>
          @foreach($lsTag as $tag)
            <option value="{{$tag->id}}">{{$tag->name}}</option>
            @endforeach
    </select>
    <br/>
    <input type="submit" value="Post" />
  </form>
</div>

@endsection
