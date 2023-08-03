namespace Utils;

public static class ApplicationConstants
{
    public const string SendDefaultPassowrdEmail = @"<!DOCTYPE html
    PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=http://www.w3.org/1999/xhtml xmlns:v=urn:schemas-microsoft-com:vml
    xmlns:o=urn:schemas-microsoft-com:office:office>

<head>
    <meta charset=UTF-8>
    <meta content=""text/html; charset=utf-8"" http-equiv=Content-Type> <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=X-UA-Compatible> <!--<![endif]-->
    <meta content=""width=device-width, initial-scale=1.0"" name=viewport>
    <meta content=""telephone=no"" name=format-detection>
    <meta content=""date=no"" name=format-detection>
    <meta content=""address=no"" name=format-detection>
    <meta content=""email=no"" name=format-detection>
    <meta name=x-apple-disable-message-reformatting>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <title>Welcome</title> <!--[if !mso]><!-->
    <style>
        @media all {

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmojLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvk4jLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmYjLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvl4jLazX3dA.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }
        }
    </style> <!--<![endif]-->
    <style>
        html,
        body {
            margin: 0 !important;
            padding: 0 !important;
            min-height: 100% !important;
            width: 100% !important;
            -webkit-font-smoothing: antialiased;
        }

        * {
            -ms-text-size-adjust: 100%;
        }

        #outlook a {
            padding: 0;
        }

        .ReadMsgBody,
        .ExternalClass {
            width: 100%;
        }

        .ExternalClass,
        .ExternalClass p,
        .ExternalClass td,
        .ExternalClass div,
        .ExternalClass span,
        .ExternalClass font {
            line-height: 100%;
        }

        div[style*=""margin: 14px 0""],
        div[style*=""margin: 16px 0""] {
            margin: 0 !important;
        }

        table,
        td,
        th {
            mso-table-lspace: 0 !important;
            mso-table-rspace: 0 !important;
            border-collapse: collapse;
        }

        body,
        td,
        th,
        p,
        div,
        li,
        a,
        span {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
            mso-line-height-rule: exactly;
        }

        img {
            border: 0;
            outline: none;
            line-height: 100%;
            text-decoration: none;
            -ms-interpolation-mode: bicubic;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
        }

        .pc-gmail-fix {
            display: none;
            display: none !important;
        }
    </style>
    <style>
        @media (max-width: 620px) {
            .pc-project-body {
                min-width: 0px !important;
            }

            .pc-project-container {
                width: 100% !important;
            }

            table.pc-w620-spacing-0-0-70-0 {
                margin: 0px 0px 70px 0px !important;
            }

            td.pc-w620-spacing-0-0-70-0,
            th.pc-w620-spacing-0-0-70-0 {
                margin: 0 !important;
                padding: 0px 0px 70px 0px !important;
            }

            table.pc-w620-spacing-0-10-0-0 {
                margin: 0px 10px 0px 0px !important;
            }

            td.pc-w620-spacing-0-10-0-0,
            th.pc-w620-spacing-0-10-0-0 {
                margin: 0 !important;
                padding: 0px 10px 0px 0px !important;
            }

            table.pc-w620-spacing-0-0-10-0 {
                margin: 0px 0px 10px 0px !important;
            }

            td.pc-w620-spacing-0-0-10-0,
            th.pc-w620-spacing-0-0-10-0 {
                margin: 0 !important;
                padding: 0px 0px 10px 0px !important;
            }

            .pc-w620-fontSize-30 {
                font-size: 30px !important;
            }

            .pc-w620-lineHeight-40 {
                line-height: 40px !important;
            }

            .pc-w620-padding-32-35-32-35 {
                padding: 32px 35px 32px 35px !important;
            }

            .pc-w620-view-vertical,
            .pc-w620-view-vertical>tbody,
            .pc-w620-view-vertical>tbody>tr,
            .pc-w620-view-vertical>tbody>tr>th,
            .pc-w620-view-vertical>tr,
            .pc-w620-view-vertical>tr>th {
                display: inline-block !important;
                width: 100% !important;
            }

            .pc-w620-padding-35-50-35-50 {
                padding: 35px 50px 35px 50px !important;
            }
        }

        @media (max-width: 520px) {
            table.pc-w520-spacing-0-0-50-0 {
                margin: 0px 0px 50px 0px !important;
            }

            td.pc-w520-spacing-0-0-50-0,
            th.pc-w520-spacing-0-0-50-0 {
                margin: 0 !important;
                padding: 0px 0px 50px 0px !important;
            }

            .pc-w520-padding-27-30-27-30 {
                padding: 27px 30px 27px 30px !important;
            }

            .pc-w520-padding-30-40-30-40 {
                padding: 30px 40px 30px 40px !important;
            }
        }
    </style> <!--[if !mso]><!---->
    <style>
        @media all {
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }
        }
    </style> <!--<![endif]--> <!--[if mso]>
    <style type=""text/css"">
        .pc-font-alt {
            font-family: Helvetica, Arial, sans-serif !important;
        }
    </style>
    <![endif]--> <!--[if gte mso 9]>
    <xml>
        <o:OfficeDocumentSettings>
            <o:AllowPNG/>
            <o:PixelsPerInch>96</o:PixelsPerInch>
        </o:OfficeDocumentSettings>
    </xml>
    <![endif]-->
</head>

<body bgcolor=#f4f4f4 class=pc-font-alt
    style=""width: 100% !important;min-height: 100% !important;margin: 0 !important;padding: 0 !important;line-height: 1.5;color: #2D3A41;mso-line-height-rule: exactly;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;-ms-text-size-adjust: 100%;font-variant-ligatures: none;text-rendering: optimizeLegibility;-moz-osx-font-smoothing: grayscale;background-color: #f4f4f4;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;"">
    <table bgcolor=#f4f4f4 border=0 cellpadding=0 cellspacing=0 class=pc-project-body role=presentation
        style=""table-layout: fixed;min-width: 600px;background-color:#f4f4f4;"" width=100%>
        <tr>
            <td align=center valign=top>
                <table align=center border=0 cellpadding=0 cellspacing=0 class=pc-project-container role=presentation
                    style=""width: 600px; max-width: 600px;"" width=600>
                    <tr>
                        <td align=left style=""padding: 20px 0px 20px 0px;"" valign=top>
                            <table border=0 cellpadding=0 cellspacing=0 role=presentation style=""width: 100%;""
                                width=100%>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#1766d1
                                                                class=""pc-w520-padding-27-30-27-30 pc-w620-padding-32-35-32-35""
                                                                style=""padding: 37px 40px 37px 40px;border-radius: 0px;background-color: #1766d1;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block role=presentation>
                                                                    <tr>
                                                                        <td class=""pc-font-alt pc-w620-fontSize-30 pc-w620-lineHeight-40""
                                                                            style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #ffffff;""
                                                                            valign=top>
                                                                            <div><span>Weather Monitoring</span> </div>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#ffffff
                                                                class=""pc-w520-padding-30-40-30-40 pc-w620-padding-35-50-35-50""
                                                                style=""padding: 40px 60px 40px 60px;border-radius: 0px;background-color: #ffffff;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=center
                                                                            style=""padding: 0px 0px 10px 0px;""
                                                                            valign=top>
                                                                            <table align=center border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation
                                                                                style=""margin-right: auto; margin-left: auto;"">
                                                                                <tr>
                                                                                    <td align=center class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #151515;text-align: center;text-align-last: center;""
                                                                                        valign=top>
                                                                                        <div><span>Welcome</span> </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=left
                                                                            style=""padding: 0px 0px 20px 0px;""
                                                                            valign=top>
                                                                            <table align=left border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation>
                                                                                <tr>
                                                                                    <td align=left class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 28px;letter-spacing: -0.2px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 20px;font-weight: normal;color: #1b1b1b;text-align: left;text-align-last: left;""
                                                                                        valign=top>
                                                                                        <div><span>Dear User,</span>
                                                                                        </div>
                                                                                        <div><span>Welcome to our
                                                                                                application! We&#39;re
                                                                                                thrilled to have you on
                                                                                                board and look forward
                                                                                                to providing you with a
                                                                                                seamless and enjoyable
                                                                                                experience.</span>
                                                                                        </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>To get started, here
                                                                                                are your login
                                                                                                credentials:<br>Username:
                                                                                                {emailid}<br>Password:
                                                                                                {password}</span> </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>Please ensure that
                                                                                                you keep your password
                                                                                                confidential and avoid
                                                                                                sharing it with
                                                                                                anyone.</span> </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>Once again, welcome
                                                                                                to our application. We
                                                                                                hope you find it useful
                                                                                                and that it fulfills all
                                                                                                your needs. Thank you
                                                                                                for choosing our
                                                                                                service.</span> </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-list-wrapper role=presentation width=100%>
                                                                    <tr>
                                                                        <td style=""padding: 0px 0px 20px 0px;""
                                                                            valign=top>
                                                                            <table border=0 cellpadding=0 cellspacing=0
                                                                                class=pc-list role=presentation
                                                                                width=100%>
                                                                                <tr>
                                                                                    <td align=center valign=top>
                                                                                        <table border=0 cellpadding=0
                                                                                            cellspacing=0
                                                                                            class=""pc-hlist pc-w620-view-vertical""
                                                                                            role=presentation>
                                                                                            <tr>
                                                                                                <th align=center
                                                                                                    style=""font-weight: normal;""
                                                                                                    valign=top> <!--[if mso]>
                <a href=""http://localhost:3000/"" target=""_blank"">
                    <v:roundrect href=""http://localhost:3000/"" stroke=""f"" fillcolor=""#1595e7"" arcsize=""8%"" style=""width: 133px;v-text-anchor: middle;"" xmlns:v=""urn:schemas-microsoft-com:vml"" xmlns:w=""urn:schemas-microsoft-com:office:word"">
                        <w:anchorlock></w:anchorlock>
                        <center style=""font-size: 16px;font-weight: 500;color: #ffffff;font-family: Arial, Helvetica, sans-serif;"">Click Here</center>
                    </v:roundrect>
                </a>
                <![endif]--> <!--[if !mso]><!--><a href=http://localhost:3000/ style=""border-radius: 8px;background-color: #1595e7;padding: 14px 18px 14px 18px;height: 24px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-weight: 500;font-size: 16px;line-height: 24px;letter-spacing: -0.2px;color: #ffffff;display: inline-block;text-align: center;text-decoration: none;white-space: nowrap;-webkit-text-size-adjust: none;""
                                                                                                        target=_blank><span><span
                                                                                                                style=""white-space: pre-wrap;"">Login
                                                                                                            </span></span></a>
                                                                                                    <!--<![endif]-->
                                                                                                </th>
                                                                                            </tr>
                                                                                        </table>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class=pc-gmail-fix style=""white-space: nowrap; font: 15px courier; line-height: 0;"">&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; </div>
</body>

</html>";
    public const string ResetPassword = @"<!DOCTYPE html
    PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=http://www.w3.org/1999/xhtml xmlns:v=urn:schemas-microsoft-com:vml
    xmlns:o=urn:schemas-microsoft-com:office:office>

<head>
    <meta charset=UTF-8>
    <meta content=""text/html; charset=utf-8"" http-equiv=Content-Type> <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=X-UA-Compatible> <!--<![endif]-->
    <meta content=""width=device-width, initial-scale=1.0"" name=viewport>
    <meta content=""telephone=no"" name=format-detection>
    <meta content=""date=no"" name=format-detection>
    <meta content=""address=no"" name=format-detection>
    <meta content=""email=no"" name=format-detection>
    <meta name=x-apple-disable-message-reformatting>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <title>Welcome</title> <!--[if !mso]><!-->
    <style>
        @media all {

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmojLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvk4jLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmYjLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvl4jLazX3dA.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }
        }
    </style> <!--<![endif]-->
    <style>
        html,
        body {
            margin: 0 !important;
            padding: 0 !important;
            min-height: 100% !important;
            width: 100% !important;
            -webkit-font-smoothing: antialiased;
        }

        * {
            -ms-text-size-adjust: 100%;
        }

        #outlook a {
            padding: 0;
        }

        .ReadMsgBody,
        .ExternalClass {
            width: 100%;
        }

        .ExternalClass,
        .ExternalClass p,
        .ExternalClass td,
        .ExternalClass div,
        .ExternalClass span,
        .ExternalClass font {
            line-height: 100%;
        }

        div[style*=""margin: 14px 0""],
        div[style*=""margin: 16px 0""] {
            margin: 0 !important;
        }

        table,
        td,
        th {
            mso-table-lspace: 0 !important;
            mso-table-rspace: 0 !important;
            border-collapse: collapse;
        }

        body,
        td,
        th,
        p,
        div,
        li,
        a,
        span {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
            mso-line-height-rule: exactly;
        }

        img {
            border: 0;
            outline: none;
            line-height: 100%;
            text-decoration: none;
            -ms-interpolation-mode: bicubic;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
        }

        .pc-gmail-fix {
            display: none;
            display: none !important;
        }
    </style>
    <style>
        @media (max-width: 620px) {
            .pc-project-body {
                min-width: 0px !important;
            }

            .pc-project-container {
                width: 100% !important;
            }

            table.pc-w620-spacing-0-0-70-0 {
                margin: 0px 0px 70px 0px !important;
            }

            td.pc-w620-spacing-0-0-70-0,
            th.pc-w620-spacing-0-0-70-0 {
                margin: 0 !important;
                padding: 0px 0px 70px 0px !important;
            }

            table.pc-w620-spacing-0-10-0-0 {
                margin: 0px 10px 0px 0px !important;
            }

            td.pc-w620-spacing-0-10-0-0,
            th.pc-w620-spacing-0-10-0-0 {
                margin: 0 !important;
                padding: 0px 10px 0px 0px !important;
            }

            table.pc-w620-spacing-0-0-10-0 {
                margin: 0px 0px 10px 0px !important;
            }

            td.pc-w620-spacing-0-0-10-0,
            th.pc-w620-spacing-0-0-10-0 {
                margin: 0 !important;
                padding: 0px 0px 10px 0px !important;
            }

            .pc-w620-fontSize-30 {
                font-size: 30px !important;
            }

            .pc-w620-lineHeight-40 {
                line-height: 40px !important;
            }

            .pc-w620-padding-32-35-32-35 {
                padding: 32px 35px 32px 35px !important;
            }

            .pc-w620-view-vertical,
            .pc-w620-view-vertical>tbody,
            .pc-w620-view-vertical>tbody>tr,
            .pc-w620-view-vertical>tbody>tr>th,
            .pc-w620-view-vertical>tr,
            .pc-w620-view-vertical>tr>th {
                display: inline-block !important;
                width: 100% !important;
            }

            .pc-w620-padding-35-50-35-50 {
                padding: 35px 50px 35px 50px !important;
            }
        }

        @media (max-width: 520px) {
            table.pc-w520-spacing-0-0-50-0 {
                margin: 0px 0px 50px 0px !important;
            }

            td.pc-w520-spacing-0-0-50-0,
            th.pc-w520-spacing-0-0-50-0 {
                margin: 0 !important;
                padding: 0px 0px 50px 0px !important;
            }

            .pc-w520-padding-27-30-27-30 {
                padding: 27px 30px 27px 30px !important;
            }

            .pc-w520-padding-30-40-30-40 {
                padding: 30px 40px 30px 40px !important;
            }
        }
    </style> <!--[if !mso]><!---->
    <style>
        @media all {
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }
        }
    </style> <!--<![endif]--> <!--[if mso]>
    <style type=""text/css"">
        .pc-font-alt {
            font-family: Helvetica, Arial, sans-serif !important;
        }
    </style>
    <![endif]--> <!--[if gte mso 9]>
    <xml>
        <o:OfficeDocumentSettings>
            <o:AllowPNG/>
            <o:PixelsPerInch>96</o:PixelsPerInch>
        </o:OfficeDocumentSettings>
    </xml>
    <![endif]-->
</head>

<body bgcolor=#f4f4f4 class=pc-font-alt
    style=""width: 100% !important;min-height: 100% !important;margin: 0 !important;padding: 0 !important;line-height: 1.5;color: #2D3A41;mso-line-height-rule: exactly;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;-ms-text-size-adjust: 100%;font-variant-ligatures: none;text-rendering: optimizeLegibility;-moz-osx-font-smoothing: grayscale;background-color: #f4f4f4;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;"">
    <table bgcolor=#f4f4f4 border=0 cellpadding=0 cellspacing=0 class=pc-project-body role=presentation
        style=""table-layout: fixed;min-width: 600px;background-color:#f4f4f4;"" width=100%>
        <tr>
            <td align=center valign=top>
                <table align=center border=0 cellpadding=0 cellspacing=0 class=pc-project-container role=presentation
                    style=""width: 600px; max-width: 600px;"" width=600>
                    <tr>
                        <td align=left style=""padding: 20px 0px 20px 0px;"" valign=top>
                            <table border=0 cellpadding=0 cellspacing=0 role=presentation style=""width: 100%;""
                                width=100%>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#1766d1
                                                                class=""pc-w520-padding-27-30-27-30 pc-w620-padding-32-35-32-35""
                                                                style=""padding: 37px 40px 37px 40px;border-radius: 0px;background-color: #1766d1;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block role=presentation>
                                                                    <tr>
                                                                        <td class=""pc-font-alt pc-w620-fontSize-30 pc-w620-lineHeight-40""
                                                                            style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #ffffff;""
                                                                            valign=top>
                                                                            <div><span>Weather Monitoring</span> </div>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#ffffff
                                                                class=""pc-w520-padding-30-40-30-40 pc-w620-padding-35-50-35-50""
                                                                style=""padding: 40px 60px 40px 60px;border-radius: 0px;background-color: #ffffff;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=center
                                                                            style=""padding: 0px 0px 10px 0px;""
                                                                            valign=top>
                                                                            <table align=center border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation
                                                                                style=""margin-right: auto; margin-left: auto;"">
                                                                                <tr>
                                                                                    <td align=center class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #151515;text-align: center;text-align-last: center;""
                                                                                        valign=top>
                                                                                        <div><span>Reset Password</span>
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=left
                                                                            style=""padding: 0px 0px 20px 0px;""
                                                                            valign=top>
                                                                            <table align=left border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation>
                                                                                <tr>
                                                                                    <td align=left class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 28px;letter-spacing: -0.2px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 20px;font-weight: normal;color: #1b1b1b;text-align: left;text-align-last: left;""
                                                                                        valign=top>
                                                                                        <div><span>Dear User,</span>
                                                                                        </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>We trust this email
                                                                                                finds you in good
                                                                                                health. We have been
                                                                                                made aware of your
                                                                                                current situation, where
                                                                                                you are encountering
                                                                                                difficulties accessing
                                                                                                your account due to a
                                                                                                forgotten password. We
                                                                                                understand the
                                                                                                frustration this may
                                                                                                cause, but we assure you
                                                                                                that we are committed to
                                                                                                assisting you in
                                                                                                recovering access to
                                                                                                your account.</span>
                                                                                        </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>Kindly find below the
                                                                                                password associated with
                                                                                                your account:</span>
                                                                                        </div>
                                                                                        <div><span>Password:
                                                                                                {password}</span> </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>We kindly request
                                                                                                that you exercise utmost
                                                                                                caution in handling your
                                                                                                password and refrain
                                                                                                from sharing it with
                                                                                                anyone. The security and
                                                                                                confidentiality of your
                                                                                                account are of utmost
                                                                                                importance to us.</span>
                                                                                        </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                        <div><span>If you have any
                                                                                                further questions or
                                                                                                require additional
                                                                                                assistance, please do
                                                                                                not hesitate to contact
                                                                                                our support team. We are
                                                                                                dedicated to providing
                                                                                                you with the necessary
                                                                                                guidance to resolve this
                                                                                                matter swiftly and
                                                                                                efficiently.</span>
                                                                                        </div>
                                                                                        <div><span>Thank you for your
                                                                                                cooperation.</span>
                                                                                        </div>
                                                                                        <div><span>﻿</span> </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class=pc-gmail-fix style=""white-space: nowrap; font: 15px courier; line-height: 0;"">&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </div>
</body>

</html>";
    public const string AirQualityTemplate = @"<!DOCTYPE html
    PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=http://www.w3.org/1999/xhtml xmlns:v=urn:schemas-microsoft-com:vml
    xmlns:o=urn:schemas-microsoft-com:office:office>

<head>
    <meta charset=UTF-8>
    <meta content=""text/html; charset=utf-8"" http-equiv=Content-Type> <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=X-UA-Compatible> <!--<![endif]-->
    <meta content=""width=device-width, initial-scale=1.0"" name=viewport>
    <meta content=""telephone=no"" name=format-detection>
    <meta content=""date=no"" name=format-detection>
    <meta content=""address=no"" name=format-detection>
    <meta content=""email=no"" name=format-detection>
    <meta name=x-apple-disable-message-reformatting>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <title>Welcome</title> <!--[if !mso]><!-->
    <style>
        @media all {

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmojLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvk4jLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmYjLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvl4jLazX3dA.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }
        }
    </style> <!--<![endif]-->
    <style>
        html,
        body {
            margin: 0 !important;
            padding: 0 !important;
            min-height: 100% !important;
            width: 100% !important;
            -webkit-font-smoothing: antialiased;
        }

        * {
            -ms-text-size-adjust: 100%;
        }

        #outlook a {
            padding: 0;
        }

        .ReadMsgBody,
        .ExternalClass {
            width: 100%;
        }

        .ExternalClass,
        .ExternalClass p,
        .ExternalClass td,
        .ExternalClass div,
        .ExternalClass span,
        .ExternalClass font {
            line-height: 100%;
        }

        div[style*=""margin: 14px 0""],
        div[style*=""margin: 16px 0""] {
            margin: 0 !important;
        }

        table,
        td,
        th {
            mso-table-lspace: 0 !important;
            mso-table-rspace: 0 !important;
            border-collapse: collapse;
        }

        body,
        td,
        th,
        p,
        div,
        li,
        a,
        span {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
            mso-line-height-rule: exactly;
        }

        img {
            border: 0;
            outline: none;
            line-height: 100%;
            text-decoration: none;
            -ms-interpolation-mode: bicubic;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
        }

        .pc-gmail-fix {
            display: none;
            display: none !important;
        }
    </style>
    <style>
        @media (max-width: 620px) {
            .pc-project-body {
                min-width: 0px !important;
            }

            .pc-project-container {
                width: 100% !important;
            }

            table.pc-w620-spacing-0-0-70-0 {
                margin: 0px 0px 70px 0px !important;
            }

            td.pc-w620-spacing-0-0-70-0,
            th.pc-w620-spacing-0-0-70-0 {
                margin: 0 !important;
                padding: 0px 0px 70px 0px !important;
            }

            table.pc-w620-spacing-0-10-0-0 {
                margin: 0px 10px 0px 0px !important;
            }

            td.pc-w620-spacing-0-10-0-0,
            th.pc-w620-spacing-0-10-0-0 {
                margin: 0 !important;
                padding: 0px 10px 0px 0px !important;
            }

            table.pc-w620-spacing-0-0-10-0 {
                margin: 0px 0px 10px 0px !important;
            }

            td.pc-w620-spacing-0-0-10-0,
            th.pc-w620-spacing-0-0-10-0 {
                margin: 0 !important;
                padding: 0px 0px 10px 0px !important;
            }

            .pc-w620-fontSize-30 {
                font-size: 30px !important;
            }

            .pc-w620-lineHeight-40 {
                line-height: 40px !important;
            }

            .pc-w620-padding-32-35-32-35 {
                padding: 32px 35px 32px 35px !important;
            }

            .pc-w620-view-vertical,
            .pc-w620-view-vertical>tbody,
            .pc-w620-view-vertical>tbody>tr,
            .pc-w620-view-vertical>tbody>tr>th,
            .pc-w620-view-vertical>tr,
            .pc-w620-view-vertical>tr>th {
                display: inline-block !important;
                width: 100% !important;
            }

            .pc-w620-padding-35-50-35-50 {
                padding: 35px 50px 35px 50px !important;
            }
        }

        @media (max-width: 520px) {
            table.pc-w520-spacing-0-0-50-0 {
                margin: 0px 0px 50px 0px !important;
            }

            td.pc-w520-spacing-0-0-50-0,
            th.pc-w520-spacing-0-0-50-0 {
                margin: 0 !important;
                padding: 0px 0px 50px 0px !important;
            }

            .pc-w520-padding-27-30-27-30 {
                padding: 27px 30px 27px 30px !important;
            }

            .pc-w520-padding-30-40-30-40 {
                padding: 30px 40px 30px 40px !important;
            }
        }
    </style> <!--[if !mso]><!---->
    <style>
        @media all {
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }
        }
    </style> <!--<![endif]--> <!--[if mso]>
    <style type=""text/css"">
        .pc-font-alt {
            font-family: Helvetica, Arial, sans-serif !important;
        }
    </style>
    <![endif]--> <!--[if gte mso 9]>
    <xml>
        <o:OfficeDocumentSettings>
            <o:AllowPNG/>
            <o:PixelsPerInch>96</o:PixelsPerInch>
        </o:OfficeDocumentSettings>
    </xml>
    <![endif]-->
</head>

<body bgcolor=#f4f4f4 class=pc-font-alt
    style=""width: 100% !important;min-height: 100% !important;margin: 0 !important;padding: 0 !important;line-height: 1.5;color: #2D3A41;mso-line-height-rule: exactly;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;-ms-text-size-adjust: 100%;font-variant-ligatures: none;text-rendering: optimizeLegibility;-moz-osx-font-smoothing: grayscale;background-color: #f4f4f4;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;"">
    <table bgcolor=#f4f4f4 border=0 cellpadding=0 cellspacing=0 class=pc-project-body role=presentation
        style=""table-layout: fixed;min-width: 600px;background-color:#f4f4f4;"" width=100%>
        <tr>
            <td align=center valign=top>
                <table align=center border=0 cellpadding=0 cellspacing=0 class=pc-project-container role=presentation
                    style=""width: 600px; max-width: 600px;"" width=600>
                    <tr>
                        <td align=left style=""padding: 20px 0px 20px 0px;"" valign=top>
                            <table border=0 cellpadding=0 cellspacing=0 role=presentation style=""width: 100%;""
                                width=100%>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#1766d1
                                                                class=""pc-w520-padding-27-30-27-30 pc-w620-padding-32-35-32-35""
                                                                style=""padding: 37px 40px 37px 40px;border-radius: 0px;background-color: #1766d1;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block role=presentation>
                                                                    <tr>
                                                                        <td class=""pc-font-alt pc-w620-fontSize-30 pc-w620-lineHeight-40""
                                                                            style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #ffffff;""
                                                                            valign=top>
                                                                            <div><span>Weather Monitoring</span> </div>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#ffffff
                                                                class=""pc-w520-padding-30-40-30-40 pc-w620-padding-35-50-35-50""
                                                                style=""padding: 40px 60px 40px 60px;border-radius: 0px;background-color: #ffffff;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=center
                                                                            style=""padding: 0px 0px 10px 0px;""
                                                                            valign=top>
                                                                            <table align=center border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation
                                                                                style=""margin-right: auto; margin-left: auto;"">
                                                                                <tr>
                                                                                    <td align=center class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #151515;text-align: center;text-align-last: center;""
                                                                                        valign=top>
                                                                                        <div><span
                                                                                                style=""color: #ff1010;"">Alert!</span>
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=left
                                                                            style=""padding: 0px 0px 20px 0px;""
                                                                            valign=top>
                                                                            <table align=left border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation>
                                                                                <tr>
                                                                                    <td align=left class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 28px;letter-spacing: -0.2px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 20px;font-weight: normal;color: #1b1b1b;text-align: left;text-align-last: left;""
                                                                                        valign=top>
                                                                                        <div><span>Dear User,</span>
                                                                                        </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>We would like to
                                                                                                inform you that an alarm
                                                                                                has been triggered by
                                                                                                {sensor.Name} at
                                                                                                {weatherStationName}.</span>
                                                                                        </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>According to the
                                                                                                latest data, the air
                                                                                                quality index recorded
                                                                                                at {datetime} is {value}
                                                                                                {unit}.</span> </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>Thank you for your
                                                                                                attention.</span> </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>Best
                                                                                                regards,<br>WeatherStation
                                                                                                Team</span> </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class=pc-gmail-fix style=""white-space: nowrap; font: 15px courier; line-height: 0;"">&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </div>
</body>

</html>";
    public const string HumditiyAlertEmailTemplate = @"<!DOCTYPE html
    PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=http://www.w3.org/1999/xhtml xmlns:v=urn:schemas-microsoft-com:vml
    xmlns:o=urn:schemas-microsoft-com:office:office>

<head>
    <meta charset=UTF-8>
    <meta content=""text/html; charset=utf-8"" http-equiv=Content-Type> <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=X-UA-Compatible> <!--<![endif]-->
    <meta content=""width=device-width, initial-scale=1.0"" name=viewport>
    <meta content=""telephone=no"" name=format-detection>
    <meta content=""date=no"" name=format-detection>
    <meta content=""address=no"" name=format-detection>
    <meta content=""email=no"" name=format-detection>
    <meta name=x-apple-disable-message-reformatting>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <title>Welcome</title> <!--[if !mso]><!-->
    <style>
        @media all {

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmojLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvk4jLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmYjLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvl4jLazX3dA.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }
        }
    </style> <!--<![endif]-->
    <style>
        html,
        body {
            margin: 0 !important;
            padding: 0 !important;
            min-height: 100% !important;
            width: 100% !important;
            -webkit-font-smoothing: antialiased;
        }

        * {
            -ms-text-size-adjust: 100%;
        }

        #outlook a {
            padding: 0;
        }

        .ReadMsgBody,
        .ExternalClass {
            width: 100%;
        }

        .ExternalClass,
        .ExternalClass p,
        .ExternalClass td,
        .ExternalClass div,
        .ExternalClass span,
        .ExternalClass font {
            line-height: 100%;
        }

        div[style*=""margin: 14px 0""],
        div[style*=""margin: 16px 0""] {
            margin: 0 !important;
        }

        table,
        td,
        th {
            mso-table-lspace: 0 !important;
            mso-table-rspace: 0 !important;
            border-collapse: collapse;
        }

        body,
        td,
        th,
        p,
        div,
        li,
        a,
        span {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
            mso-line-height-rule: exactly;
        }

        img {
            border: 0;
            outline: none;
            line-height: 100%;
            text-decoration: none;
            -ms-interpolation-mode: bicubic;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
        }

        .pc-gmail-fix {
            display: none;
            display: none !important;
        }
    </style>
    <style>
        @media (max-width: 620px) {
            .pc-project-body {
                min-width: 0px !important;
            }

            .pc-project-container {
                width: 100% !important;
            }

            table.pc-w620-spacing-0-0-70-0 {
                margin: 0px 0px 70px 0px !important;
            }

            td.pc-w620-spacing-0-0-70-0,
            th.pc-w620-spacing-0-0-70-0 {
                margin: 0 !important;
                padding: 0px 0px 70px 0px !important;
            }

            table.pc-w620-spacing-0-10-0-0 {
                margin: 0px 10px 0px 0px !important;
            }

            td.pc-w620-spacing-0-10-0-0,
            th.pc-w620-spacing-0-10-0-0 {
                margin: 0 !important;
                padding: 0px 10px 0px 0px !important;
            }

            table.pc-w620-spacing-0-0-10-0 {
                margin: 0px 0px 10px 0px !important;
            }

            td.pc-w620-spacing-0-0-10-0,
            th.pc-w620-spacing-0-0-10-0 {
                margin: 0 !important;
                padding: 0px 0px 10px 0px !important;
            }

            .pc-w620-fontSize-30 {
                font-size: 30px !important;
            }

            .pc-w620-lineHeight-40 {
                line-height: 40px !important;
            }

            .pc-w620-padding-32-35-32-35 {
                padding: 32px 35px 32px 35px !important;
            }

            .pc-w620-view-vertical,
            .pc-w620-view-vertical>tbody,
            .pc-w620-view-vertical>tbody>tr,
            .pc-w620-view-vertical>tbody>tr>th,
            .pc-w620-view-vertical>tr,
            .pc-w620-view-vertical>tr>th {
                display: inline-block !important;
                width: 100% !important;
            }

            .pc-w620-padding-35-50-35-50 {
                padding: 35px 50px 35px 50px !important;
            }
        }

        @media (max-width: 520px) {
            table.pc-w520-spacing-0-0-50-0 {
                margin: 0px 0px 50px 0px !important;
            }

            td.pc-w520-spacing-0-0-50-0,
            th.pc-w520-spacing-0-0-50-0 {
                margin: 0 !important;
                padding: 0px 0px 50px 0px !important;
            }

            .pc-w520-padding-27-30-27-30 {
                padding: 27px 30px 27px 30px !important;
            }

            .pc-w520-padding-30-40-30-40 {
                padding: 30px 40px 30px 40px !important;
            }
        }
    </style> <!--[if !mso]><!---->
    <style>
        @media all {
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }
        }
    </style> <!--<![endif]--> <!--[if mso]>
    <style type=""text/css"">
        .pc-font-alt {
            font-family: Helvetica, Arial, sans-serif !important;
        }
    </style>
    <![endif]--> <!--[if gte mso 9]>
    <xml>
        <o:OfficeDocumentSettings>
            <o:AllowPNG/>
            <o:PixelsPerInch>96</o:PixelsPerInch>
        </o:OfficeDocumentSettings>
    </xml>
    <![endif]-->
</head>

<body bgcolor=#f4f4f4 class=pc-font-alt
    style=""width: 100% !important;min-height: 100% !important;margin: 0 !important;padding: 0 !important;line-height: 1.5;color: #2D3A41;mso-line-height-rule: exactly;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;-ms-text-size-adjust: 100%;font-variant-ligatures: none;text-rendering: optimizeLegibility;-moz-osx-font-smoothing: grayscale;background-color: #f4f4f4;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;"">
    <table bgcolor=#f4f4f4 border=0 cellpadding=0 cellspacing=0 class=pc-project-body role=presentation
        style=""table-layout: fixed;min-width: 600px;background-color:#f4f4f4;"" width=100%>
        <tr>
            <td align=center valign=top>
                <table align=center border=0 cellpadding=0 cellspacing=0 class=pc-project-container role=presentation
                    style=""width: 600px; max-width: 600px;"" width=600>
                    <tr>
                        <td align=left style=""padding: 20px 0px 20px 0px;"" valign=top>
                            <table border=0 cellpadding=0 cellspacing=0 role=presentation style=""width: 100%;""
                                width=100%>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#1766d1
                                                                class=""pc-w520-padding-27-30-27-30 pc-w620-padding-32-35-32-35""
                                                                style=""padding: 37px 40px 37px 40px;border-radius: 0px;background-color: #1766d1;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block role=presentation>
                                                                    <tr>
                                                                        <td class=""pc-font-alt pc-w620-fontSize-30 pc-w620-lineHeight-40""
                                                                            style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #ffffff;""
                                                                            valign=top>
                                                                            <div><span>Weather Monitoring</span> </div>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#ffffff
                                                                class=""pc-w520-padding-30-40-30-40 pc-w620-padding-35-50-35-50""
                                                                style=""padding: 40px 60px 40px 60px;border-radius: 0px;background-color: #ffffff;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=center
                                                                            style=""padding: 0px 0px 10px 0px;""
                                                                            valign=top>
                                                                            <table align=center border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation
                                                                                style=""margin-right: auto; margin-left: auto;"">
                                                                                <tr>
                                                                                    <td align=center class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #151515;text-align: center;text-align-last: center;""
                                                                                        valign=top>
                                                                                        <div><span
                                                                                                style=""color: #ff1010;"">Alert!</span>
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=left
                                                                            style=""padding: 0px 0px 20px 0px;""
                                                                            valign=top>
                                                                            <table align=left border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation>
                                                                                <tr>
                                                                                    <td align=left class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 28px;letter-spacing: -0.2px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 20px;font-weight: normal;color: #1b1b1b;text-align: left;text-align-last: left;""
                                                                                        valign=top>
                                                                                        <div><span>Dear User,</span>
                                                                                        </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>We would like to
                                                                                                inform you that an alarm
                                                                                                has been triggered by
                                                                                                {sensor.Name} at
                                                                                                {weatherStationName}.</span>
                                                                                        </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>According to the
                                                                                                latest data, the
                                                                                                humidity
                                                                                                recorded
                                                                                                at {datetime} is {value}
                                                                                                {unit}.</span> </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>Thank you for your
                                                                                                attention.</span> </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>Best
                                                                                                regards,<br>WeatherStation
                                                                                                Team</span> </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class=pc-gmail-fix style=""white-space: nowrap; font: 15px courier; line-height: 0;"">&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </div>
</body>

</html>";
    public const string temperautreAlert = @"<!DOCTYPE html
    PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=http://www.w3.org/1999/xhtml xmlns:v=urn:schemas-microsoft-com:vml
    xmlns:o=urn:schemas-microsoft-com:office:office>

<head>
    <meta charset=UTF-8>
    <meta content=""text/html; charset=utf-8"" http-equiv=Content-Type> <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=X-UA-Compatible> <!--<![endif]-->
    <meta content=""width=device-width, initial-scale=1.0"" name=viewport>
    <meta content=""telephone=no"" name=format-detection>
    <meta content=""date=no"" name=format-detection>
    <meta content=""address=no"" name=format-detection>
    <meta content=""email=no"" name=format-detection>
    <meta name=x-apple-disable-message-reformatting>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <link
        href=""https://fonts.googleapis.com/css?family=Fira+Sans:ital,wght@0,100;1,100;0,200;1,200;0,300;1,300;0,400;1,400;0,500;1,500;0,600;1,600;0,700;1,700;0,800;1,800;0,900;1,900""
        rel=stylesheet>
    <title>Welcome</title> <!--[if !mso]><!-->
    <style>
        @media all {

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmojLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvk4jLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5VvmYjLazX3dGTP.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: local('Fira Sans Regular'), local('FiraSans-Regular'), url(https://fonts.gstatic.com/s/firasans/v10/va9E4kDNxMZdWfMOD5Vvl4jLazX3dA.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: local('Fira Sans Medium'), local('FiraSans-Medium'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnZKveRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }

            /* cyrillic-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSxf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0460-052F, U+1C80-1C88, U+20B4, U+2DE0-2DFF, U+A640-A69F, U+FE2E-FE2F;
            }

            /* cyrillic */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eQhf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0400-045F, U+0490-0491, U+04B0-04B1, U+2116;
            }

            /* latin-ext */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eSBf6Xl7Gl3LX.woff2) format('woff2');
                unicode-range: U+0100-024F, U+0259, U+1E00-1EFF, U+2020, U+20A0-20AB, U+20AD-20CF, U+2113, U+2C60-2C7F, U+A720-A7FF;
            }

            /* latin */
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                font-display: swap;
                src: local('Fira Sans ExtraBold'), local('FiraSans-ExtraBold'), url(https://fonts.gstatic.com/s/firasans/v10/va9B4kDNxMZdWfMOD5VnMK7eRhf6Xl7Glw.woff2) format('woff2');
                unicode-range: U+0000-00FF, U+0131, U+0152-0153, U+02BB-02BC, U+02C6, U+02DA, U+02DC, U+2000-206F, U+2074, U+20AC, U+2122, U+2191, U+2193, U+2212, U+2215, U+FEFF, U+FFFD;
            }
        }
    </style> <!--<![endif]-->
    <style>
        html,
        body {
            margin: 0 !important;
            padding: 0 !important;
            min-height: 100% !important;
            width: 100% !important;
            -webkit-font-smoothing: antialiased;
        }

        * {
            -ms-text-size-adjust: 100%;
        }

        #outlook a {
            padding: 0;
        }

        .ReadMsgBody,
        .ExternalClass {
            width: 100%;
        }

        .ExternalClass,
        .ExternalClass p,
        .ExternalClass td,
        .ExternalClass div,
        .ExternalClass span,
        .ExternalClass font {
            line-height: 100%;
        }

        div[style*=""margin: 14px 0""],
        div[style*=""margin: 16px 0""] {
            margin: 0 !important;
        }

        table,
        td,
        th {
            mso-table-lspace: 0 !important;
            mso-table-rspace: 0 !important;
            border-collapse: collapse;
        }

        body,
        td,
        th,
        p,
        div,
        li,
        a,
        span {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
            mso-line-height-rule: exactly;
        }

        img {
            border: 0;
            outline: none;
            line-height: 100%;
            text-decoration: none;
            -ms-interpolation-mode: bicubic;
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
        }

        .pc-gmail-fix {
            display: none;
            display: none !important;
        }
    </style>
    <style>
        @media (max-width: 620px) {
            .pc-project-body {
                min-width: 0px !important;
            }

            .pc-project-container {
                width: 100% !important;
            }

            table.pc-w620-spacing-0-0-70-0 {
                margin: 0px 0px 70px 0px !important;
            }

            td.pc-w620-spacing-0-0-70-0,
            th.pc-w620-spacing-0-0-70-0 {
                margin: 0 !important;
                padding: 0px 0px 70px 0px !important;
            }

            table.pc-w620-spacing-0-10-0-0 {
                margin: 0px 10px 0px 0px !important;
            }

            td.pc-w620-spacing-0-10-0-0,
            th.pc-w620-spacing-0-10-0-0 {
                margin: 0 !important;
                padding: 0px 10px 0px 0px !important;
            }

            table.pc-w620-spacing-0-0-10-0 {
                margin: 0px 0px 10px 0px !important;
            }

            td.pc-w620-spacing-0-0-10-0,
            th.pc-w620-spacing-0-0-10-0 {
                margin: 0 !important;
                padding: 0px 0px 10px 0px !important;
            }

            .pc-w620-fontSize-30 {
                font-size: 30px !important;
            }

            .pc-w620-lineHeight-40 {
                line-height: 40px !important;
            }

            .pc-w620-padding-32-35-32-35 {
                padding: 32px 35px 32px 35px !important;
            }

            .pc-w620-view-vertical,
            .pc-w620-view-vertical>tbody,
            .pc-w620-view-vertical>tbody>tr,
            .pc-w620-view-vertical>tbody>tr>th,
            .pc-w620-view-vertical>tr,
            .pc-w620-view-vertical>tr>th {
                display: inline-block !important;
                width: 100% !important;
            }

            .pc-w620-padding-35-50-35-50 {
                padding: 35px 50px 35px 50px !important;
            }
        }

        @media (max-width: 520px) {
            table.pc-w520-spacing-0-0-50-0 {
                margin: 0px 0px 50px 0px !important;
            }

            td.pc-w520-spacing-0-0-50-0,
            th.pc-w520-spacing-0-0-50-0 {
                margin: 0 !important;
                padding: 0px 0px 50px 0px !important;
            }

            .pc-w520-padding-27-30-27-30 {
                padding: 27px 30px 27px 30px !important;
            }

            .pc-w520-padding-30-40-30-40 {
                padding: 30px 40px 30px 40px !important;
            }
        }
    </style> <!--[if !mso]><!---->
    <style>
        @media all {
            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5Vn9LjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 100;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fdw.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9A4kDNxMZdWfMOD5VvkrCqUT7fcQ.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnWKneSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBiQyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjN.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9E4kDNxMZdWfMOD5VvmYjL.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnZKveSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 300;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnPKreSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 500;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrA6Qif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 400;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTQ.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9C4kDNxMZdWfMOD5VvkrjHYTI.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnSKzeSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrByRCf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 600;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAWRSf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 700;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnLK3eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBKRif2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrBuRyf2VFk.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 800;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnMK7eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: normal;
                font-weight: 900;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9B4kDNxMZdWfMOD5VnFK_eSBf6.woff2') format('woff2');
            }

            @font-face {
                font-family: 'Fira Sans';
                font-style: italic;
                font-weight: 200;
                src: url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VF8.woff') format('woff'), url('https://fonts.gstatic.com/s/firasans/v16/va9f4kDNxMZdWfMOD5VvkrAGQCf2VFk.woff2') format('woff2');
            }
        }
    </style> <!--<![endif]--> <!--[if mso]>
    <style type=""text/css"">
        .pc-font-alt {
            font-family: Helvetica, Arial, sans-serif !important;
        }
    </style>
    <![endif]--> <!--[if gte mso 9]>
    <xml>
        <o:OfficeDocumentSettings>
            <o:AllowPNG/>
            <o:PixelsPerInch>96</o:PixelsPerInch>
        </o:OfficeDocumentSettings>
    </xml>
    <![endif]-->
</head>

<body bgcolor=#f4f4f4 class=pc-font-alt
    style=""width: 100% !important;min-height: 100% !important;margin: 0 !important;padding: 0 !important;line-height: 1.5;color: #2D3A41;mso-line-height-rule: exactly;-webkit-font-smoothing: antialiased;-webkit-text-size-adjust: 100%;-ms-text-size-adjust: 100%;font-variant-ligatures: none;text-rendering: optimizeLegibility;-moz-osx-font-smoothing: grayscale;background-color: #f4f4f4;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;"">
    <table bgcolor=#f4f4f4 border=0 cellpadding=0 cellspacing=0 class=pc-project-body role=presentation
        style=""table-layout: fixed;min-width: 600px;background-color:#f4f4f4;"" width=100%>
        <tr>
            <td align=center valign=top>
                <table align=center border=0 cellpadding=0 cellspacing=0 class=pc-project-container role=presentation
                    style=""width: 600px; max-width: 600px;"" width=600>
                    <tr>
                        <td align=left style=""padding: 20px 0px 20px 0px;"" valign=top>
                            <table border=0 cellpadding=0 cellspacing=0 role=presentation style=""width: 100%;""
                                width=100%>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#1766d1
                                                                class=""pc-w520-padding-27-30-27-30 pc-w620-padding-32-35-32-35""
                                                                style=""padding: 37px 40px 37px 40px;border-radius: 0px;background-color: #1766d1;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block role=presentation>
                                                                    <tr>
                                                                        <td class=""pc-font-alt pc-w620-fontSize-30 pc-w620-lineHeight-40""
                                                                            style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #ffffff;""
                                                                            valign=top>
                                                                            <div><span>Weather Monitoring</span> </div>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td valign=top>
                                        <table border=0 cellpadding=0 cellspacing=0 role=presentation width=100%>
                                            <tr>
                                                <td style=""padding: 0px 0px 0px 0px;"">
                                                    <table border=0 cellpadding=0 cellspacing=0 role=presentation
                                                        width=100%>
                                                        <tr>
                                                            <td bgcolor=#ffffff
                                                                class=""pc-w520-padding-30-40-30-40 pc-w620-padding-35-50-35-50""
                                                                style=""padding: 40px 60px 40px 60px;border-radius: 0px;background-color: #ffffff;""
                                                                valign=top>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=center
                                                                            style=""padding: 0px 0px 10px 0px;""
                                                                            valign=top>
                                                                            <table align=center border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation
                                                                                style=""margin-right: auto; margin-left: auto;"">
                                                                                <tr>
                                                                                    <td align=center class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 46px;letter-spacing: -0.6px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 36px;font-weight: 800;color: #151515;text-align: center;text-align-last: center;""
                                                                                        valign=top>
                                                                                        <div><span
                                                                                                style=""color: #ff1010;"">Alert!</span>
                                                                                        </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                                <table border=0 cellpadding=0 cellspacing=0
                                                                    class=pc-txt-block-wrapper role=presentation
                                                                    width=100%>
                                                                    <tr>
                                                                        <td align=left
                                                                            style=""padding: 0px 0px 20px 0px;""
                                                                            valign=top>
                                                                            <table align=left border=0 cellpadding=0
                                                                                cellspacing=0 class=pc-txt-block
                                                                                role=presentation>
                                                                                <tr>
                                                                                    <td align=left class=pc-font-alt
                                                                                        style=""mso-line-height: exactly;line-height: 28px;letter-spacing: -0.2px;font-family: 'Fira Sans', Helvetica, Arial, sans-serif;font-size: 20px;font-weight: normal;color: #1b1b1b;text-align: left;text-align-last: left;""
                                                                                        valign=top>
                                                                                        <div><span>Dear User,</span>
                                                                                        </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>We would like to
                                                                                                inform you that an alarm
                                                                                                has been triggered by
                                                                                                {sensor.Name} at
                                                                                                {weatherStationName}.</span>
                                                                                        </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>According to the
                                                                                                latest data, the
                                                                                                temperature
                                                                                                recorded
                                                                                                at {datetime} is {value}
                                                                                                {unit}.</span> </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>Thank you for your
                                                                                                attention.</span> </div>
                                                                                        <div><span>&#xFEFF;</span>
                                                                                        </div>
                                                                                        <div><span>Best
                                                                                                regards,<br>WeatherStation
                                                                                                Team</span> </div>
                                                                                    </td>
                                                                                </tr>
                                                                            </table>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class=pc-gmail-fix style=""white-space: nowrap; font: 15px courier; line-height: 0;"">&nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </div>
</body>

</html>";
}