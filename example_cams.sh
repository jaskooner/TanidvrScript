#!/usr/bin/env bash

tanidvr="./tanidvr"
mode=1
target="glasgowpub.you.change"
user=username_you_change
password=some_user_password_you_change
mediaplayer=mplayer

for value in {0..3}
do
	$tanidvr -m $mode -t $target -u $user -w $password -c $value | $mediaplayer -cache 32 - 2>/dev/null &
done

echo all done