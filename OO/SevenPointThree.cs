using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public class Artist
    {
        public string Name { get; set; }
        public Artist(string name)
        {
            Name = name;
        }
    }

    public class Album
    {
        public Artist Artist { get; set; }
        public DateTime LaunchDate { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public Album(Artist artist, DateTime launchDate, string name, List<Song> songs)
        {
            Artist = artist;
            LaunchDate = launchDate;
            Name = name;
            Songs = songs;
        }
    }
    public class Song
    {
        public string Name { get; set; }
        public TimeSpan Durantion { get; set; }
        public Album Album { get; set; }

        public Song(string name, TimeSpan durantion, Album album)
        {
            Name = name;
            Durantion = durantion;
            Album = album;
        }
    }

    public class Playlist
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Song> Songs { get; set; }

        private Song _currentSong;
        private int currentSongIndex { get { return Songs.IndexOf(_currentSong); } }

        public Playlist(string name)
        {
            Name = name;
            CreatedDate = DateTime.Now;
            Songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public Song GetNextSong()
        {
            return Songs[currentSongIndex + 1];
        }
    }

    public class JukeBox
    {
        public ObservableCollection<Song> Songs { get; set; }

        public List<Playlist> Playlists { get; set; }

        public JukeBox()
        {
            Songs = new ObservableCollection<Song>();
            Playlists = new List<Playlist>();
            Songs.CollectionChanged += Songs_CollectionChanged;
        }

        private void Songs_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var newSongs = e.NewItems as List<Song>;
            foreach (var item in newSongs)
            {
                PlayASong(item);
            }
        }

        public Playlist CreatePlaylist(string name)
        {
            var playList = new Playlist(name);
            Playlists.Add(playList);
            return playList;
        }

        public void AddSongAPlayList(Playlist playlist, Song song)
        {
            playlist.AddSong(song);
        }

        public void PlayAlbum(Album album)
        {
            Songs = new ObservableCollection<Song>(album.Songs);
        }

        public void PlayAPlaylist(Playlist playlist)
        {
            Songs = new ObservableCollection<Song>(playlist.Songs);
        }

        public void EnqueueASong(Song song)
        {
            Songs.Add(song);
        }

        private void PlayASong(Song song)
        {

        }
    }
}
