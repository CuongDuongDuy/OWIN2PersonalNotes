﻿namespace OAuth2PersonalNotes.Share
{
    public class Constants
    {
        public const string NotesApi = "http://localhost:27477/";
        public const string NotesMvc = "http://localhost:16538/";
        public const string NotesMvcstsCallback = "http://localhost:16538/stscallback";
        public const string NotesAngular = "https://localhost:44316/";

        public const string NotesClientSecret = "myrandomclientsecret";

        public const string NotesIssuerUri = "https://CuongDuong.Personalnotes/identity";
        public const string NotesStsOrigin = "https://localhost:44304";
        public const string NotesSts = NotesStsOrigin + "/identity";
        public const string NotesStsTokenEndpoint = NotesSts + "/connect/token";
        public const string NotesStsAuthorizationEndpoint = NotesSts + "/connect/authorize";
        public const string NotesStsUserInfoEndpoint = NotesSts + "/connect/userinfo";
        public const string NotesStsEndSessionEndpoint = NotesSts + "/connect/endsession";
        public const string NotesStsRevokeTokenEndpoint = NotesSts + "/connect/revocation";
    }
}
