namespace Community
{
    namespace Model
    {
        enum AuthSubjectType
        {

        }
        enum UserFlag
        {
            Inactivated = 0,
            Activated = 1,
            EmailActivated = 2,
            PhoneActivated = 4,
            Blocked = 8,
            Muted = 16,
        }

        enum AuthActionType
        {
            Register = 0,
            Activate = 1,
            Login = 2,
            Logout = 3
        }
        enum GenderType
        {
            Other = 0,
            Male = 1,
            Female = 2,

        }
        // MODULE: User, prefix = usr

        namespace User
        {
            class User
            {
                // == Common == 
                uint64 Id;
                uint64 CreatedTime;
                uint64 UpdatedTime;
                string ScreenName;
                string AvatarUrl;
                string Motto;
                UserFlag UserFlag;

                // == Privacy ==
                string? Username;
                string? PhoneNumber;
                string? Email;
                string Password;
                string Salt;
            }

            class AuthLog
            {
                uint64 Id;
                AuthActionType ActionType;
                string ClientIP;
                uint64 CreatedTime;
                uint64 UpdatedTime;
                // == Refer ==
                User User; // Get By Id
            }

            class Profile
            {
                string RealName;
                uint64 BirthDay;
                GenderType Gender;
                string Location;
                string Website;
                string School;
                // == Refer ==
                User User;
            }

            class Preference
            {
                uint64 Id;
                string ItemKey;
                string ItemValue;
                // == Refer ==
                User User;
            }

            class Group { }

            class Permission { }
        }

    }
}
