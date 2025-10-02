CREATE SCHEMA giny_auth;
CREATE SCHEMA giny_world;

use giny_auth;
source /init-script/giny_auth.sql;
       
use giny_world;
source /init-script/giny_world/giny_world.sql;
source /init-script/dungeons_patch.sql;
