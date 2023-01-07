# GetWindowTitle
ユーザーが現在開いているウィンドウのタイトルをゴーストが覗けるようになるプラグイン。<br>
過去に書いた記事のものをプラグイン化しました。<br>
[【伺か】Ghostからアクションを起こしてほしかったので、ユーザーの画面の覗き込むコードを書いた【yaya】 -- 異風堂々](https://ambergonslibrary.com/ukagaka/7360/)<br>


## 動作環境
- Windows10
- SSP/2.6.25 (20221225-2; Windows NT 10.0.19045)


## 使い方
#### 呼び出し。
コードが実行されたタイミングで現在トップで表示されているウィンドウ名を取得します。<br>
ゴーストがトップの場合はゴーストの名前(sakura)が取得されます。<br>
なので、ユーザーが見つめているかどうかの判定にも使えます。<br>
```
"\![raiseplugin,GetWindowTitle,OnGetWindowTitle]"
```

また、下記のようにすると少したってから実行されるので、デバッグテストにでもお使いください。<br>
```
"\w9\w9\w9\w9\w9\![raiseplugin,GetWindowTitle,OnGetWindowTitle]"
```


#### ウィンドウタイトルの受け取り
ゴースト側に下記の関数を実装してください。<br>
下記の例だと、呼び出しを受けた際にウィンドウタイトル名を読み上げるようになっています。<br>
```
OnRecieveGetWindowTitle {
    _title = reference[0]
    _title
}
```


#### ウィンドウタイトルの受け取りの実装例。
下記の実装例は、自前ゴーストに導入するつもりだったものの廃案になったものです。<br>
参考にでもしてください。<br>
yayaで書かれています。<br>
```
OnRecieveGetWindowTitle {
    _window_title = reference[0]

    //マッチしてしまうとそこで確定してしまうのでデカいカテゴリほど後ろに回すとよい。
    if ( RE_SEARCH( _window_title , "iTunes") == 1 ) {
        "どんな曲が好き？\n/
        私はJAZZアレンジとかがいいな。\n/
        もとがアニメやゲームの曲のアレンジ曲とか大好きだよ\e"
        "私、レトロゲームのサウンドトラックとかもよく聞いちゃうんだけどね、ネットでは売ってないんだ・・・iTunesもあんまり扱ってないんだよね・・・"

    } elseif ( RE_SEARCH( _window_title , "AviUtl") == 1 ) || ( RE_SEARCH( _window_title , "拡張編集") == 1 ){
        "今日は動画編集の日？\n/
        頑張って！"

    } elseif ( RE_SEARCH( _window_title , "Studio One") == 1 ) {
        "今日は作曲？編曲の日？"

    } elseif ( RE_SEARCH( _window_title , "ラジオ") == 1 ) || ( RE_SEARCH( _window_title , "radio") == 1 ) {
        "実はラジオ動画の投稿なんかもしてたり。。。 \nこれ、秘密ね。"

    } elseif ( RE_SEARCH( _window_title , "TRPG") == 1 ) {
        "TRPGって面白そうだよね。 いつかやってみたいんだけど環境がね～。 まずTRPGを楽しんでくれる友人を用意します！ ・・・ハァ。。"


    //以下デカいカテゴリ
    } elseif ( RE_SEARCH( _window_title , "ASMR") == 1 ) {
        "耳舐め。。。いや、何でもないです。"
        "耳をふさいでる音ってすごいよね。。"

    } elseif ( RE_SEARCH( _window_title , "FANZA") == 1 ) || ( RE_SEARCH( _window_title , "アダルト") == 1 ) || ( RE_SEARCH( _window_title , "エロい単語とかその辺") == 1 ) {
        "ッ！！。。。。！！！！ "

    } elseif ( RE_SEARCH( _window_title , "VOICEROID2") == 1 ) {
        "調声って難しいよねぇ。。。"

    } elseif ( RE_SEARCH( _window_title , "ニコニコ動画") == 1 ) {
        "ニ～コニコ動画♪  ドワンゴじゃない何かが 。。。今何時だっけ。%(hour)時過ぎをお知らせするよ～"

    } elseif ( RE_SEARCH( _window_title , "") == 1 ) {
        //""
    } elseif ( RE_SEARCH( _window_title , "") == 1 ) {
    } else {
        //_window_title
    }
}
```


## お借りしたもの
yaya.dll<br>
[Releases · YAYA-shiori/yaya-shiori · GitHub](https://github.com/YAYA-shiori/yaya-shiori/releases)<br>

proxy_ex.dll<br>
[Release SAORI : proxy_ex v1.0.2 · ukatech/csaori · GitHub](https://github.com/ukatech/csaori/releases/tag/saori_proxy_ex_v1.0.2)<br>


## Other
このプログラムを利用することによるいかなる問題や損害に対して、私は責任を負いません。<br>
これらをゴースト等に同梱して配布していただいて構いません。<br>
また、プラグインとしてではなく、ゴースト本体に組み込んでいただいてもかまいません。<br>


## 小言
これを書いた当初はゴーストに可能な限りそこにいる雰囲気を出してくれることを望んでいたのですが、<br>
迷走した果てに没になりました。<br>
もしよければ遊んでみてください。<br>



## Author
[ambergon](https://twitter.com/Sc_lFoxGon)




