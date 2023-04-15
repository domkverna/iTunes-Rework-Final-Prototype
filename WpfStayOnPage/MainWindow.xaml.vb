Class MainWindow

    'library, album, and songs buttons with extra layout elements
    Private Sub libraryButton_Click(sender As Object, e As RoutedEventArgs) Handles libraryButton.Click, doneWithPhoneButton.Click
        'Visibility Settings
        albumsScroll.Visibility = Visibility.Hidden
        songCanvas.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        judasScroll.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Hidden
        iTunesRadioBlack.Visibility = Visibility.Hidden
        iTunesRadioRed.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Hidden
        iTunesStoreBlack.Visibility = Visibility.Hidden
        iTunesStoreCyan.Visibility = Visibility.Hidden
        purchaseScroll.Visibility = Visibility.Hidden
        storeSearchBox.Visibility = Visibility.Hidden
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Hidden
        allScroll.Visibility = Visibility.Visible
        libraryStackRectangle.Visibility = Visibility.Visible
        libraryStackPanel.Visibility = Visibility.Visible
        iTunesLibraryBlack.Visibility = Visibility.Visible
        iTunesLibraryPurple.Visibility = Visibility.Visible
        librarySearchBox.Visibility = Visibility.Visible

        'Play buttons
        playIMGpurple.Visibility = Visibility.Visible
        skipBackwardIMGpurple.Visibility = Visibility.Visible
        skipForwardIMGpurple.Visibility = Visibility.Visible
        playIMGred.Visibility = Visibility.Hidden
        skipBackwardIMGred.Visibility = Visibility.Hidden
        skipForwardIMGred.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Hidden
        skipBackwardIMGcyan.Visibility = Visibility.Hidden
        skipForwardIMGcyan.Visibility = Visibility.Hidden
        'Button Color Change
        libraryButton.Background = SystemColors.GradientActiveCaptionBrush
        albumsButton.Background = Brushes.White
        songsButton.Background = Brushes.White
        storeButton.Background = Brushes.White
        allButton.Background = SystemColors.GradientActiveCaptionBrush
        judasButton.Background = Brushes.White
        metallicaButton.Background = Brushes.White
        radioButton.Background = Brushes.White
    End Sub
    Private Sub allButton_Click(sender As Object, e As RoutedEventArgs)
        'Scroll Visibility
        allScroll.Visibility = Visibility.Visible
        judasScroll.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        'Change Button Color
        allButton.Background = SystemColors.GradientActiveCaptionBrush
        judasButton.Background = Brushes.White
        metallicaButton.Background = Brushes.White
    End Sub

    Private Sub judasButton_Click(sender As Object, e As RoutedEventArgs)
        'Scroll Visibility
        judasScroll.Visibility = Visibility.Visible
        metallicaScroll.Visibility = Visibility.Hidden
        allScroll.Visibility = Visibility.Hidden
        'Change Button Color
        allButton.Background = Brushes.White
        judasButton.Background = SystemColors.GradientActiveCaptionBrush
        metallicaButton.Background = Brushes.White
    End Sub

    Private Sub metallicaButton_Click(sender As Object, e As RoutedEventArgs)
        'Scroll Visibility
        metallicaScroll.Visibility = Visibility.Visible
        judasScroll.Visibility = Visibility.Hidden
        allScroll.Visibility = Visibility.Hidden
        'Change Button Color
        allButton.Background = Brushes.White
        judasButton.Background = Brushes.White
        metallicaButton.Background = SystemColors.GradientActiveCaptionBrush
    End Sub

    Private Sub albumsButton_Click(sender As Object, e As RoutedEventArgs) Handles albumsButton.Click

        'Scroll Visibility
        allScroll.Visibility = Visibility.Hidden
        iTunesLibraryBlack.Visibility = Visibility.Visible
        iTunesLibraryPurple.Visibility = Visibility.Visible
        judasScroll.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        songCanvas.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Hidden
        iTunesRadioBlack.Visibility = Visibility.Hidden
        iTunesRadioRed.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Hidden
        iTunesStoreBlack.Visibility = Visibility.Hidden
        iTunesStoreCyan.Visibility = Visibility.Hidden
        purchaseScroll.Visibility = Visibility.Hidden
        librarySearchBox.Visibility = Visibility.Visible
        storeSearchBox.Visibility = Visibility.Hidden
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
        'Play buttons
        playIMGpurple.Visibility = Visibility.Visible
        skipBackwardIMGpurple.Visibility = Visibility.Visible
        skipForwardIMGpurple.Visibility = Visibility.Visible
        playIMGred.Visibility = Visibility.Hidden
        skipBackwardIMGred.Visibility = Visibility.Hidden
        skipForwardIMGred.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Hidden
        skipBackwardIMGcyan.Visibility = Visibility.Hidden
        skipForwardIMGcyan.Visibility = Visibility.Hidden
        'Controls Visibility
        libraryStackRectangle.Visibility = Visibility.Hidden
        libraryStackPanel.Visibility = Visibility.Hidden
        'Album Scroll Visibility
        albumsScroll.Visibility = Visibility.Visible
        'Change Button Color
        songsButton.Background = Brushes.White
        libraryButton.Background = Brushes.White
        storeButton.Background = Brushes.White
        albumsButton.Background = SystemColors.GradientActiveCaptionBrush
        radioButton.Background = Brushes.White
    End Sub

    Private Sub songsButton_Click(sender As Object, e As RoutedEventArgs) Handles songsButton.Click
        'Scroll Visibility
        allScroll.Visibility = Visibility.Hidden
        iTunesLibraryBlack.Visibility = Visibility.Visible
        iTunesLibraryPurple.Visibility = Visibility.Visible
        judasScroll.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        albumsScroll.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Hidden
        iTunesRadioBlack.Visibility = Visibility.Hidden
        iTunesRadioRed.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Hidden
        iTunesStoreBlack.Visibility = Visibility.Hidden
        iTunesStoreCyan.Visibility = Visibility.Hidden
        purchaseScroll.Visibility = Visibility.Hidden
        librarySearchBox.Visibility = Visibility.Visible
        storeSearchBox.Visibility = Visibility.Hidden
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
        'Play buttons
        playIMGpurple.Visibility = Visibility.Visible
        skipBackwardIMGpurple.Visibility = Visibility.Visible
        skipForwardIMGpurple.Visibility = Visibility.Visible
        playIMGred.Visibility = Visibility.Hidden
        skipBackwardIMGred.Visibility = Visibility.Hidden
        skipForwardIMGred.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Hidden
        skipBackwardIMGcyan.Visibility = Visibility.Hidden
        skipForwardIMGcyan.Visibility = Visibility.Hidden
        'Controls Visibility
        libraryStackRectangle.Visibility = Visibility.Hidden
        libraryStackPanel.Visibility = Visibility.Hidden
        'Song Canvas Visibility
        songCanvas.Visibility = Visibility.Visible
        'Change Button Color
        libraryButton.Background = Brushes.White
        albumsButton.Background = Brushes.White
        storeButton.Background = Brushes.White
        songsButton.Background = SystemColors.GradientActiveCaptionBrush
        radioButton.Background = Brushes.White
    End Sub

    'Regular Controls
    Private Sub closeButton_Click(sender As Object, e As RoutedEventArgs) Handles closeButton.Click
        Me.Close()
    End Sub

    Private Sub helpControlButton_Click(sender As Object, e As RoutedEventArgs) Handles helpControlButton.Click
        System.Diagnostics.Process.Start("https://dverna1.wixsite.com/the-itunes-project")
    End Sub

    'Search box stuff
    Private Sub librarySearchBox_Focus(sender As Object, e As RoutedEventArgs) Handles librarySearchBox.GotFocus
        librarySearchBox.Text = ""
    End Sub
    Private Sub librarySearch_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles librarySearchBox.KeyDown
        If e.Key = Key.Enter Then
            librarySearchBox.Text = "Painkiller"
            noSongFoundInLibraryCanvas.Visibility = Visibility.Visible
        End If
    End Sub
    Private Sub librarySearchBox_lostFocus(sender As Object, e As RoutedEventArgs) Handles librarySearchBox.LostFocus
        If librarySearchBox.Text <> "" Then

        Else
            librarySearchBox.Text = "Search"
        End If

    End Sub


    Private Sub radioButton_Click(sender As Object, e As RoutedEventArgs) Handles radioButton.Click
        allScroll.Visibility = Visibility.Hidden
        iTunesLibraryBlack.Visibility = Visibility.Hidden
        iTunesLibraryPurple.Visibility = Visibility.Hidden
        judasScroll.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        albumsScroll.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Visible
        iTunesRadioBlack.Visibility = Visibility.Visible
        iTunesRadioRed.Visibility = Visibility.Visible
        storeScroll.Visibility = Visibility.Hidden
        iTunesStoreBlack.Visibility = Visibility.Hidden
        iTunesStoreCyan.Visibility = Visibility.Hidden
        purchaseScroll.Visibility = Visibility.Hidden
        librarySearchBox.Visibility = Visibility.Hidden
        storeSearchBox.Visibility = Visibility.Hidden
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
        'Play buttons
        playIMGpurple.Visibility = Visibility.Hidden
        skipBackwardIMGpurple.Visibility = Visibility.Hidden
        skipForwardIMGpurple.Visibility = Visibility.Hidden
        playIMGred.Visibility = Visibility.Visible
        skipBackwardIMGred.Visibility = Visibility.Visible
        skipForwardIMGred.Visibility = Visibility.Visible
        playIMGcyan.Visibility = Visibility.Hidden
        skipBackwardIMGcyan.Visibility = Visibility.Hidden
        skipForwardIMGcyan.Visibility = Visibility.Hidden
        'Controls Visibility
        libraryStackRectangle.Visibility = Visibility.Hidden
        libraryStackPanel.Visibility = Visibility.Hidden
        'Song Canvas Visibility
        songCanvas.Visibility = Visibility.Visible
        'Change Button Color
        libraryButton.Background = Brushes.White
        albumsButton.Background = Brushes.White
        songsButton.Background = Brushes.White
        storeButton.Background = Brushes.White
        radioButton.Background = SystemColors.GradientActiveCaptionBrush
    End Sub


    '=====================Radio page buttons====================='

    'kjazz remove
    Private Sub removekjazz_Click(sender As Object, e As RoutedEventArgs) Handles removekjazz.Click
        favoritekjazzIMG.Visibility = Visibility.Collapsed
        favoriteKjazzCanvas.Visibility = Visibility.Collapsed
    End Sub

    'mega remove
    Private Sub removeMega_Click(sender As Object, e As RoutedEventArgs) Handles removeMega.Click
        favoriteMegaIMG.Visibility = Visibility.Collapsed
        favoriteMegaCanvas.Visibility = Visibility.Collapsed
    End Sub

    'kday add and remove
    Private Sub addKday_Click(sender As Object, e As RoutedEventArgs) Handles addKday.Click
        favoriteKdayIMG.Visibility = Visibility.Visible
        favoriteKdayCanvas.Visibility = Visibility.Visible
    End Sub
    Private Sub removeKday_Click(sender As Object, e As RoutedEventArgs) Handles removeKday.Click
        favoriteKdayIMG.Visibility = Visibility.Collapsed
        favoriteKdayCanvas.Visibility = Visibility.Collapsed
    End Sub

    'wrif add and remove
    Private Sub addwrif_Click(sender As Object, e As RoutedEventArgs) Handles addWrif.Click
        favoriteWrifIMG.Visibility = Visibility.Visible
        favoriteWrifCanvas.Visibility = Visibility.Visible
    End Sub
    Private Sub removewrif_Click(sender As Object, e As RoutedEventArgs) Handles removewrif.Click
        favoriteWrifIMG.Visibility = Visibility.Collapsed
        favoriteWrifCanvas.Visibility = Visibility.Collapsed
    End Sub


    '=====================Store Page Buttons====================='
    Private Sub storeButton_Click(sender As Object, e As RoutedEventArgs) Handles storeButton.Click
        allScroll.Visibility = Visibility.Hidden
        iTunesLibraryBlack.Visibility = Visibility.Hidden
        iTunesLibraryPurple.Visibility = Visibility.Hidden
        judasScroll.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        albumsScroll.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Hidden
        iTunesRadioBlack.Visibility = Visibility.Hidden
        iTunesRadioRed.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Visible
        iTunesStoreBlack.Visibility = Visibility.Visible
        iTunesStoreCyan.Visibility = Visibility.Visible
        purchaseScroll.Visibility = Visibility.Hidden
        librarySearchBox.Visibility = Visibility.Hidden
        storeSearchBox.Visibility = Visibility.Visible
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
        'Play buttons
        playIMGpurple.Visibility = Visibility.Hidden
        skipBackwardIMGpurple.Visibility = Visibility.Hidden
        skipForwardIMGpurple.Visibility = Visibility.Hidden
        playIMGred.Visibility = Visibility.Hidden
        skipBackwardIMGred.Visibility = Visibility.Hidden
        skipForwardIMGred.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Visible
        skipBackwardIMGcyan.Visibility = Visibility.Visible
        skipForwardIMGcyan.Visibility = Visibility.Visible
        'Controls Visibility
        libraryStackRectangle.Visibility = Visibility.Hidden
        libraryStackPanel.Visibility = Visibility.Hidden
        'Song Canvas Visibility
        songCanvas.Visibility = Visibility.Visible
        'Change Button Color
        libraryButton.Background = Brushes.White
        albumsButton.Background = Brushes.White
        songsButton.Background = Brushes.White
        radioButton.Background = Brushes.White
        storeButton.Background = SystemColors.GradientActiveCaptionBrush
    End Sub
    Private Sub albumClick(sender As Object, e As RoutedEventArgs) Handles metallicaIMG.MouseDown, DODIMG.MouseDown, BSIMG.MouseDown, HTHIMG.MouseDown, toxicityIMG.MouseDown, GHIMG.MouseDown, DFIMG.MouseDown,
                                                                           PKIMG.MouseDown, BEIMG.MouseDown, SNIMG.MouseDown, WIAIMG.MouseDown, AWIMG.MouseDown, SHIMG.MouseDown, SHDIMG.MouseDown, EIMG.MouseDown, RIMG.MouseDown,
                                                                           DIMG.MouseDown, MGRIMG.MouseDown, MHIMG.MouseDown, SGIMG.MouseDown, painkillerIMG.MouseDown, humanIMG.MouseDown, pain_killerIMG.MouseDown,
                                                                           executionIMG.MouseDown
        allScroll.Visibility = Visibility.Hidden
        iTunesLibraryBlack.Visibility = Visibility.Hidden
        iTunesLibraryPurple.Visibility = Visibility.Hidden
        judasScroll.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        albumsScroll.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Hidden
        iTunesRadioBlack.Visibility = Visibility.Hidden
        iTunesRadioRed.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Hidden
        purchaseScroll.Visibility = Visibility.Visible
        librarySearchBox.Visibility = Visibility.Hidden
        storeSearchBox.Visibility = Visibility.Visible
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
    End Sub


    '=====================Buying Page Buttons====================='
    Private Sub backToStoreButton_Click(sender As Object, e As RoutedEventArgs) Handles backToStoreButton.Click
        purchaseScroll.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Visible
    End Sub

    Private Sub closeAreYouSureSingleCanvasButton_Click(sender As Object, e As RoutedEventArgs) Handles closeAreYouSureSingleCanvasButton.Click
        areyousureSingleCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub cancelSingleSongPurchaseButton_Click(sender As Object, e As RoutedEventArgs) Handles cancelSingleSongPurchaseButton.Click
        areyousureSingleCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub purchaseTrouble_Click(sender As Object, e As RoutedEventArgs) Handles purchaseTrouble.Click
        areyousureSingleCanvas.Visibility = Visibility.Visible
    End Sub

    Private Sub buySingleSongButton_Click(sender As Object, e As RoutedEventArgs) Handles buySingleSongButton.Click
        purchaseTrouble.Visibility = Visibility.Hidden
        areyousureSingleCanvas.Visibility = Visibility.Hidden
    End Sub
    Private Sub password_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles passwordPurchaseSingle.KeyDown
        If e.Key = Key.Enter Then
            buySingleSongButton.IsEnabled = True
        End If
    End Sub

    Private Sub closeAreYouSureAllCanvasButton_Click(sender As Object, e As RoutedEventArgs) Handles closeAreYouSureAllCanvasButton.Click
        areyousureAllCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub cancelAllSongPurchaseButton_Click(sender As Object, e As RoutedEventArgs) Handles cancelAllSongPurchaseButton.Click
        areyousureAllCanvas.Visibility = Visibility.Hidden
    End Sub
    Private Sub passwordAll_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles passwordPurchaseAll.KeyDown
        If e.Key = Key.Enter Then
            buyAllSongButton.IsEnabled = True
        End If
    End Sub

    Private Sub buyAllSongButton_Click(sender As Object, e As RoutedEventArgs) Handles buyAllSongButton.Click
        purchaseTrouble.Visibility = Visibility.Hidden
        purchaseGoneAway.Visibility = Visibility.Hidden
        purchaseLiftMeUp.Visibility = Visibility.Hidden
        purchaseWash.Visibility = Visibility.Hidden
        purchaseBad.Visibility = Visibility.Hidden
        purchaseUnder.Visibility = Visibility.Hidden
        purchaseWrongSide.Visibility = Visibility.Hidden
        purchaseHouse.Visibility = Visibility.Hidden
        purchaseApologize.Visibility = Visibility.Hidden
        purchaseBleeding.Visibility = Visibility.Hidden
        purchaseJekyll.Visibility = Visibility.Hidden
        purchaseRemember.Visibility = Visibility.Hidden
        purchaseComingDown.Visibility = Visibility.Hidden
        purchaseNemesis.Visibility = Visibility.Hidden
        purchaseBattleBorn.Visibility = Visibility.Hidden
        purchaseFarFromHome.Visibility = Visibility.Hidden
        libraryStackRectangle.Visibility = Visibility.Hidden
        libraryStackPanel.Visibility = Visibility.Hidden
        purchaseAllButton.IsEnabled = False
        purchaseAllButton.Content = "Purchased"
        areyousureAllCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub purchaseAllButton_Click(sender As Object, e As RoutedEventArgs) Handles purchaseAllButton.Click
        areyousureAllCanvas.Visibility = Visibility.Visible
    End Sub

    Private Sub screamingForVengeanceButton_Click(sender As Object, e As RoutedEventArgs) Handles screamingForVengeanceButton.Click
        svDisplayIMG.Visibility = Visibility.Visible
        firepowerDisplayIMG.Visibility = Visibility.Hidden
        seasonsrDisplayIMG.Visibility = Visibility.Hidden
        lightningrDisplayIMG.Visibility = Visibility.Hidden
    End Sub

    Private Sub firepowerButton_Click(sender As Object, e As RoutedEventArgs) Handles firepowerButton.Click
        firepowerDisplayIMG.Visibility = Visibility.Visible
        svDisplayIMG.Visibility = Visibility.Hidden
        seasonsrDisplayIMG.Visibility = Visibility.Hidden
        lightningrDisplayIMG.Visibility = Visibility.Hidden
    End Sub

    Private Sub luxButton_Click(sender As Object, e As RoutedEventArgs) Handles luxButton.Click
        firepowerDisplayIMG.Visibility = Visibility.Hidden
        svDisplayIMG.Visibility = Visibility.Hidden
        seasonsrDisplayIMG.Visibility = Visibility.Visible
        lightningrDisplayIMG.Visibility = Visibility.Hidden
    End Sub

    Private Sub fightfireButton_Click(sender As Object, e As RoutedEventArgs) Handles fightfireButton.Click
        firepowerDisplayIMG.Visibility = Visibility.Hidden
        svDisplayIMG.Visibility = Visibility.Hidden
        seasonsrDisplayIMG.Visibility = Visibility.Hidden
        lightningrDisplayIMG.Visibility = Visibility.Visible
    End Sub

    Private Sub closeNoSongFoundInLibraryCanvas_Click(sender As Object, e As RoutedEventArgs) Handles closeNoSongFoundInLibraryCanvas.Click
        noSongFoundInLibraryCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub noSongFoundOkay_Click(sender As Object, e As RoutedEventArgs) Handles noSongFoundOkay.Click
        noSongFoundInLibraryCanvas.Visibility = Visibility.Hidden
    End Sub
    Private Sub storeSearchBox_Focus(sender As Object, e As RoutedEventArgs) Handles storeSearchBox.GotFocus
        storeSearchBox.Text = ""
    End Sub
    Private Sub storesearch_KeyPress(ByVal sender As System.Object, ByVal e As KeyEventArgs) Handles storeSearchBox.KeyDown
        If e.Key = Key.Enter Then
            storeSearchBox.Text = "Painkiller"
            searchScroll.Visibility = Visibility.Visible
        End If
    End Sub
    Private Sub storeSearchBox_lostFocus(sender As Object, e As RoutedEventArgs) Handles storeSearchBox.LostFocus
        If storeSearchBox.Text <> "" Then

        Else
            storeSearchBox.Text = "Search"
        End If

    End Sub

    Private Sub connectPhone_Click(sender As Object, e As RoutedEventArgs) Handles connectPhoneButton.Click
        connectedDisconnectedButton.Content = "Connected"
        connectPhoneButton.IsEnabled = False
        disconnectPhoneButton.IsEnabled = True
    End Sub
    Private Sub disconnectPhone_Click(sender As Object, e As RoutedEventArgs) Handles disconnectPhoneButton.Click
        'Visibility Settings
        albumsScroll.Visibility = Visibility.Hidden
        songCanvas.Visibility = Visibility.Hidden
        metallicaScroll.Visibility = Visibility.Hidden
        judasScroll.Visibility = Visibility.Hidden
        radioScroll.Visibility = Visibility.Hidden
        iTunesRadioBlack.Visibility = Visibility.Hidden
        iTunesRadioRed.Visibility = Visibility.Hidden
        storeScroll.Visibility = Visibility.Hidden
        iTunesStoreBlack.Visibility = Visibility.Hidden
        iTunesStoreCyan.Visibility = Visibility.Hidden
        purchaseScroll.Visibility = Visibility.Hidden
        storeSearchBox.Visibility = Visibility.Hidden
        searchScroll.Visibility = Visibility.Hidden
        phoneCanvas.Visibility = Visibility.Hidden
        storageCanvas.Visibility = Visibility.Hidden
        iTunesPhonePurple.Visibility = Visibility.Hidden
        iTunesPhoneBlack.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Hidden
        allScroll.Visibility = Visibility.Visible
        libraryStackRectangle.Visibility = Visibility.Visible
        libraryStackPanel.Visibility = Visibility.Visible
        iTunesLibraryBlack.Visibility = Visibility.Visible
        iTunesLibraryPurple.Visibility = Visibility.Visible
        librarySearchBox.Visibility = Visibility.Visible

        'Play buttons
        playIMGpurple.Visibility = Visibility.Visible
        skipBackwardIMGpurple.Visibility = Visibility.Visible
        skipForwardIMGpurple.Visibility = Visibility.Visible
        playIMGred.Visibility = Visibility.Hidden
        skipBackwardIMGred.Visibility = Visibility.Hidden
        skipForwardIMGred.Visibility = Visibility.Hidden
        playIMGcyan.Visibility = Visibility.Hidden
        skipBackwardIMGcyan.Visibility = Visibility.Hidden
        skipForwardIMGcyan.Visibility = Visibility.Hidden
        connectedDisconnectedButton.Content = "Disconnected"
        connectPhoneButton.IsEnabled = True
        disconnectPhoneButton.IsEnabled = False
        'Button Color Change
        libraryButton.Background = SystemColors.GradientActiveCaptionBrush
        albumsButton.Background = Brushes.White
        songsButton.Background = Brushes.White
        storeButton.Background = Brushes.White
        allButton.Background = SystemColors.GradientActiveCaptionBrush
        judasButton.Background = Brushes.White
        metallicaButton.Background = Brushes.White
        radioButton.Background = Brushes.White
    End Sub

    Private Sub closeUpToDate_Click(sender As Object, e As RoutedEventArgs) Handles closeUpToDate.Click
        phoneIsUpToDateCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub upToDateOkay_Click(sender As Object, e As RoutedEventArgs) Handles upToDateOkay.Click
        phoneIsUpToDateCanvas.Visibility = Visibility.Hidden
    End Sub

    Private Sub checkForUpdateButton_Click(sender As Object, e As RoutedEventArgs) Handles checkForUpdateButton.Click
        phoneIsUpToDateCanvas.Visibility = Visibility.Visible
    End Sub

    Private Sub backUpNowButton_Click(sender As Object, e As RoutedEventArgs) Handles backUpNowButton.Click
        If iCloudRadioButton.IsChecked = True Then
            backupTextbox.Text = "Your phone was backed up to iCloud on " + Date.Now
        ElseIf computerRadioButton.IsChecked = True Then
            backupTextbox.Text = "Your phone was backed up to this computer on " + Date.Now
        End If
    End Sub

    Private Sub connectedDisconnectedButton_Click(sender As Object, e As RoutedEventArgs) Handles connectedDisconnectedButton.Click
        If connectedDisconnectedButton.Content = "Connected" Then
            allScroll.Visibility = Visibility.Hidden
            iTunesLibraryBlack.Visibility = Visibility.Hidden
            iTunesLibraryPurple.Visibility = Visibility.Hidden
            judasScroll.Visibility = Visibility.Hidden
            metallicaScroll.Visibility = Visibility.Hidden
            albumsScroll.Visibility = Visibility.Hidden
            radioScroll.Visibility = Visibility.Hidden
            iTunesRadioBlack.Visibility = Visibility.Hidden
            iTunesRadioRed.Visibility = Visibility.Hidden
            storeScroll.Visibility = Visibility.Hidden
            iTunesStoreBlack.Visibility = Visibility.Hidden
            iTunesStoreCyan.Visibility = Visibility.Hidden
            purchaseScroll.Visibility = Visibility.Hidden
            librarySearchBox.Visibility = Visibility.Hidden
            storeSearchBox.Visibility = Visibility.Hidden
            searchScroll.Visibility = Visibility.Hidden
            libraryStackRectangle.Visibility = Visibility.Hidden
            libraryStackPanel.Visibility = Visibility.Hidden
            songCanvas.Visibility = Visibility.Hidden
            iTunesPhonePurple.Visibility = Visibility.Visible
            iTunesPhoneBlack.Visibility = Visibility.Visible
            phoneCanvas.Visibility = Visibility.Visible
            storageCanvas.Visibility = Visibility.Visible
        Else

        End If
    End Sub


End Class
